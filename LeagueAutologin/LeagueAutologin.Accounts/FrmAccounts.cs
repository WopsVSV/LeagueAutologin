using LeagueAutologin.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LeagueAutologin.Accounts
{
    public partial class FrmAccounts : Form
    {
        private XmlConfiguration xml;

        public FrmAccounts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load accounts and expand treeview.
        /// </summary>
        private void FrmAccounts_Load(object sender, EventArgs e)
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

            // Avoid ugly selection
            this.ActiveControl = lblUI1;
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

        /// <summary>
        /// When the user hovers over the ? sign, the password should be visible.
        /// </summary>
        private void btnShowPassword_MouseHover(object sender, EventArgs e) => txtPassword.UseSystemPasswordChar = false;
        private void btnShowPassword_MouseLeave(object sender, EventArgs e) => txtPassword.UseSystemPasswordChar = true;

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrEmpty(txtUsername.Text)) { MessageBox.Show("Username field cannot be empty."); return; }
            if (string.IsNullOrEmpty(txtPassword.Text)) { MessageBox.Show("Password field cannot be empty."); return; }
            if (string.IsNullOrEmpty(cbRegion.SelectedItem.ToString())) { MessageBox.Show("Region field cannot be empty."); return; }

            // Create encrypted password
            try
            {
                byte[] salt = AES.GenerateSalt();
                byte[] passkey = GetPasskey(txtUsername.Text);
                byte[] encryptedPassword = AES.Encrypt(
                     Encoding.UTF8.GetBytes(txtPassword.Text),
                     salt, passkey);


                // Create account object
                Account acc = new Account(
                    txtUsername.Text, 
                    encryptedPassword, 
                    salt,
                    txtNickname.Text, 
                    cbRegion.SelectedItem.ToString());

                // Add account to the XML document and save
                xml.AddAccount(acc);
                xml.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding a new account.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear password
            txtPassword.Clear();
            
            // Refresh tree view
            LoadAccounts();

            // Display green text (success)
            var tmr = new Timer() { Interval = 650 };
            tmr.Tick += (o, ev) =>
            {
                btnAddAccount.ForeColor = Color.Black;
                tmr.Stop();
            };
            btnAddAccount.ForeColor = Color.Green;
            tmr.Start();
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

        /// <summary>
        /// Removes the selected account
        /// </summary>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tvAccounts.SelectedNode != null)
            {
                if (tvAccounts.SelectedNode.Nodes.Count == 0)
                {
                    xml.RemoveAccount((Account)tvAccounts.SelectedNode.Tag);
                    xml.Save();
                    LoadAccounts();
                }
            }
        }

        /// <summary>
        /// Used to avoid right click bug.
        /// </summary>
        private void tvAccounts_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvAccounts.SelectedNode = e.Node;
            }
        }
    }
}
