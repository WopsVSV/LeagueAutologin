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

            // Select a default rank & division
            cbRegion.SelectedIndex = 2;
            cbRank.SelectedIndex = 0;
            cbRankDivision.SelectedIndex = 0;

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
                accList.Clear();

                // Read accounts
                var accounts = xml.ReadAccounts();

                // Add to tree
                foreach (var acc in accounts)
                {
                    accList.Add(new AccListItem(acc));                
                }

                accList.Refresh();
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

            // Create rank text
            string rank = cbRank.GetItemText(cbRank.SelectedItem);
            string division = cbRankDivision.GetItemText(cbRankDivision.SelectedItem);

            string accountRank;
            if (rank == "Unranked" || rank == "Master" || rank == "Grandmaster" || rank == "Challenger")
                accountRank = rank;
            else
                accountRank = rank + " " + division;

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
                    cbRegion.SelectedItem.ToString(),
                    accountRank);

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
            
        }


        /// <summary>
        /// Generates a passkey based on the mac address and username
        /// </summary>
        private byte[] GetPasskey(string username)
        {
            return Encoding.UTF8.GetBytes(Environment.UserName + username);
        }

        /// <summary>
        /// Removes the selected account
        /// </summary>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (accList.LastHoveredItem() != null) {
                xml.RemoveAccount(accList.LastHoveredItem().Account);
                xml.Save();

                LoadAccounts();
            }
        }

        private void cmsTreeView_Opening(object sender, CancelEventArgs e)
        {

        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (accList.LastHoveredItem() != null)
            {
                RankSelectionForm rankDialog = new RankSelectionForm();

                // Show testDialog as a modal dialog and determine if DialogResult = OK.
                if (rankDialog.ShowDialog(this) == DialogResult.OK)
                {
                    xml.ChangeAccount(accList.LastHoveredItem().Account, rankDialog.fullRank.Text);
                    xml.Save();
                    LoadAccounts();
                    
                }
                else
                {
                    MessageBox.Show("Rank selection cancelled");
                }
                rankDialog.Dispose();

            }
        }
    }
}
