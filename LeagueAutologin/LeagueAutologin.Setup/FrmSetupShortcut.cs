using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeagueAutologin.Setup
{
    public partial class FrmSetupShortcut : Form
    {
        // Form size
        private bool FormExtended = false;
        private const int HEIGHT_FORM_REGULAR = 154;
        private const int HEIGHT_FORM_EXTENDED = 308;

        // League location
        private const string DEFAULT_CLIENT_LOCATION = "C:/Riot Games/League of Legends/LeagueClient.exe";

        public FrmSetupShortcut()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changes the form size from regular to extended or the other way around when the Help button is clicked.
        /// </summary>
        private void btnHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FormExtended)
            {
                this.Size = new Size(this.Size.Width, HEIGHT_FORM_REGULAR);
                FormExtended = false;
            }
            else
            {
                this.Size = new Size(this.Size.Width, HEIGHT_FORM_EXTENDED);
                FormExtended = true;
            }
        }

        /// <summary>
        /// Creates and displays an open file dialog allowing the user to select the League client executable.
        /// </summary>
        private void btnSelectLeagueClient_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "LeagueClient.exe|LeagueClient.exe";
            openFileDialog.FileOk += (snd, ev) =>
            {
                txtLeagueClientLocation.Text = openFileDialog.FileName;
            };
            openFileDialog.ShowDialog();
        }

        /// <summary>
        /// Checks if the League Client is in the default location and sets the location if true.
        /// </summary>
        private void FrmSetupShortcut_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(DEFAULT_CLIENT_LOCATION))
                txtLeagueClientLocation.Text = DEFAULT_CLIENT_LOCATION;

            // Sets the active control to an UI label to avoid ugly selection of textbox on load.
            this.ActiveControl = lblUI1;
        }

        private void btnCreateShortcut_Click(object sender, EventArgs e)
        {
            if (txtLeagueClientLocation.Text == string.Empty) {
                MessageBox.Show("Please select the LeagueClient.exe location.\nUse the \"Don't know what to do?\" button below for more information.", "Cannot proceed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string currentDirectory = Application.StartupPath;

            // Create the file that stores the startup information for the shortcut.
            string shortcutInfoFile = currentDirectory + "/shortcutInfo.txt";
            // Other solution executables
            string extensionAppPath = currentDirectory + "/LeagueAutologin.Extension.exe";
            string accountsAppPath = currentDirectory + "/LeagueAutologin.Accounts.exe";

            if (!System.IO.File.Exists(extensionAppPath)) {
                MessageBox.Show("Could not find LeagueAutologin.Extension.exe inside the application's directory.\nNote: The three LeagueAutologin executables: Extension, Setup, Accounts and the three images, have to be in the same directory.", "Cannot proceed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!System.IO.File.Exists(accountsAppPath)) {
                MessageBox.Show("Could not find LeagueAutologin.Accounts.exe inside the application's directory.\nNote: The three LeagueAutologin executables: Extension, Setup, Accounts and the three images, have to be in the same directory.", "Cannot proceed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Write the league client location to the shortcut file
            System.IO.File.WriteAllText(shortcutInfoFile, txtLeagueClientLocation.Text, Encoding.UTF8);

            // Create the shortcut
            try
            {
                object shDesktop = (object)"Desktop";
                WshShell shell = new WshShell();
                string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) +
                                         @"\LoL Autologin.lnk";

                // If already exists, delete it
                if (System.IO.File.Exists(shortcutAddress))
                    System.IO.File.Delete(shortcutAddress);

                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.Description = "League of Legends with an Autologin widget.";
                shortcut.IconLocation = txtLeagueClientLocation.Text + ",0";
                shortcut.TargetPath = extensionAppPath;
                shortcut.WorkingDirectory = Application.StartupPath;
                shortcut.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the shortcut.\n" + ex.Message, "Cannot proceed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Shortcut successfully saved on the desktop.\nYou can open your League of Legends client through the shortcut now.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Starts the Accounts program.
        private void btnSetupAccounts_Click(object sender, EventArgs e)
        {
            try {
                var proc = System.Diagnostics.Process.GetProcessesByName("LeagueAutologin.Accounts");
                if(proc.Length > 0)
                {
                    var res = MessageBox.Show("Accounts window is already open. Do you wish to close it and open another one?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(res == DialogResult.Yes)
                    {
                        proc[0].Kill();
                        System.Diagnostics.Process.Start("LeagueAutologin.Accounts.exe");
                    }
                }
                else
                    System.Diagnostics.Process.Start("LeagueAutologin.Accounts.exe");
            }
            catch {
                MessageBox.Show("Could not load up the accounts program. Make sure LeagueAutologin.Accounts.exe is present in the same folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
