using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LeagueAutologin.Extension
{
    public partial class FrmWidget : Form
    {
        private XmlConfiguration xml;
        private Process proc;
        private PositionData[] positionData;

        // Logos for multiple client sizes
        Bitmap logoBmp1280 = new Bitmap("logo1280.bmp");
        Bitmap logoBmp1024 = new Bitmap("logo1024.bmp");
        Bitmap logoBmp1600 = new Bitmap("logo1600.bmp");

        public FrmWidget()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load XML and accounts, start League client.
        /// </summary>
        private void FrmWidget_Load(object sender, EventArgs e)
        {
            // Setup XML
            if (!System.IO.File.Exists("accounts.xml"))
            {
                var launchDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                xml = XmlConfiguration.CreateConfiguration(launchDir + "/accounts.xml");
            }
            else
            {
                xml = new XmlConfiguration("accounts.xml");
            }

            // Load accounts
            LoadAccounts();

            // Load position data
            positionData = new PositionData[3];
            positionData[0] = new PositionData(1280, 720, 67, 284, 67, 348, 188, 495, 66, 56);
            positionData[1] = new PositionData(1024, 576, 53, 225, 53, 278, 150, 397, 53, 45);
            positionData[2] = new PositionData(1600, 900, 84, 355, 84, 435, 233, 621, 82, 70);

            // Focus
            this.ActiveControl = btnClose;

            // TODO: Start process
            string shortcutInfoFile = Application.StartupPath + "/shortcutInfo.txt";
            string leagueClientFile = string.Empty;
            try
            {
                leagueClientFile = System.IO.File.ReadAllText(shortcutInfoFile).Replace("\n", string.Empty).Replace("\r", string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to read the shortcutInfo.txt file.\n" + ex.Message);
                Application.Exit();
            }
            Process.Start(leagueClientFile);

            // Start looking for process
            tmrCheckProcess.Start();
        }

        /// <summary>
        /// Loads accounts from XML file and into the TreeView
        /// </summary>
        private void LoadAccounts()
        {
            try
            {
                // Clear tree
                tvAccounts.Nodes.Clear();

                // Read accounts
                var accounts = xml.ReadAccounts();

                // Add to tree
                foreach (var acc in accounts)
                {
                    // If region doesn't exist, create it
                    if (tvAccounts.Nodes[acc.Region] == null)
                    {
                        tvAccounts.Nodes.Add(acc.Region, acc.Region);
                    }

                    // Add nickname if available for label
                    var label = string.IsNullOrEmpty(acc.Nickname) ? acc.Username : acc.Nickname;
                    TreeNode node = new TreeNode(label)
                    {
                        Tag = acc // Crucial tag to hold account information
                    };
                    tvAccounts.Nodes[acc.Region].Nodes.Add(node);
                }

                tvAccounts.ExpandAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while loading accounts.\n" + ex.Message, "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        /// <summary>
        /// Checks the screen for the League logo (checks if client is visible)
        /// </summary>
        private void tmrCheckScreen_Tick(object sender, EventArgs e)
        {
            Rectangle rect = FormHelper.GetWindowRectangle(this, proc.MainWindowHandle);

            // Check window size before (only 3 supported)
            Bitmap logo = logoBmp1280;
            PositionData posData = positionData[0];
            if (rect.Width == 1280) { logo = logoBmp1280; posData = positionData[0]; }
            if (rect.Width == 1024) { logo = logoBmp1024; posData = positionData[1]; }
            if (rect.Width == 1600) { logo = logoBmp1600; posData = positionData[2]; }

            // Screen capture bounds (start at client position + offset and end depending on logo size)
            Rectangle bounds = new Rectangle(rect.X + posData.LogoX, rect.Y + posData.LogoY, logo.Width, logo.Height);

            // Capture
            Bitmap screenBmp = new Bitmap(logo.Width, logo.Height);
            using (Graphics g = Graphics.FromImage(screenBmp)) {
                g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }

            // Check if logo & screen capture match
            bool equals = FormHelper.CompareMemCmp(screenBmp, logo);

            // If its a match, display the widget and stop the timer.
            if(equals == true) {
                DisplayForm();
                tmrCheckScreen.Stop();
            }

            screenBmp.Dispose();
        }

        private void DisplayForm()
        {
            Relocate();
            this.Opacity = 1.0;
            this.Enabled = true;
            tmrRelocateForm.Start();
        }

        /// <summary>
        /// Check processes until RiotClientUx starts.
        /// </summary>
        private void tmrCheckProcess_Tick(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("RiotClientUx");

            if (proc.Length > 0)
            {
                Rectangle rect = FormHelper.GetWindowRectangle(this, proc[0].MainWindowHandle);
                if (rect.Width >= 512)
                {
                    this.proc = proc[0];
                    tmrCheckScreen.Start();
                    tmrCheckProcess.Stop();
                }
            }
        }

        private void tmrRelocateForm_Tick(object sender, EventArgs e) => Relocate();

        private void Relocate()
        {
            Rectangle rect = FormHelper.GetWindowRectangle(this, proc.MainWindowHandle);

            if (Location.X != rect.X || Location.Y != rect.Y)
                Location = new Point(rect.X - this.Width + 1, rect.Y);
        }


        private void tvAccounts_DoubleClick(object sender, EventArgs e)
        {
            if(tvAccounts.SelectedNode.Tag != null)
            {
                // Window rect
                Rectangle rect = FormHelper.GetWindowRectangle(this, proc.MainWindowHandle); 
                
                // Positional data
                PositionData posData = positionData[0];
                if (rect.Width == 1280) posData = positionData[0];
                if (rect.Width == 1024) posData = positionData[1];
                if (rect.Width == 1600) posData = positionData[2];

                // Account
                Account acc = (Account)tvAccounts.SelectedNode.Tag;
                string cleanPassword = Encoding.UTF8.GetString(AES.Decrypt(acc.Password, acc.Salt, GetPasskey(acc.Username)));

                LoginMacro.ExecuteMacro(posData, rect, acc.Username, cleanPassword);

                Application.Exit();
            }
        }

        /// <summary>
        /// Gets the computer's MAC address.
        /// </summary>
        private string GetMacAddress()
        {
            var macAddr =
            (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();
            return macAddr;
        }

        /// <summary>
        /// Generates a passkey based on the mac address and username
        /// </summary>
        private byte[] GetPasskey(string username)
        {
            return Encoding.UTF8.GetBytes(GetMacAddress() + username);
        }
    }
}
