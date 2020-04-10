namespace LeagueAutologin.Accounts
{
    partial class FrmAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccounts));
            this.cmsTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUI1 = new System.Windows.Forms.Label();
            this.lblUI2 = new System.Windows.Forms.Label();
            this.lblUI3 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.lblUI4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.LinkLabel();
            this.lblUI5 = new System.Windows.Forms.Label();
            this.cbRank = new System.Windows.Forms.ComboBox();
            this.cbRankDivision = new System.Windows.Forms.ComboBox();
            this.accList = new LeagueAutologin.Accounts.AccList();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsTreeView
            // 
            this.cmsTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.cmsTreeView.Name = "cmsTreeView";
            this.cmsTreeView.Size = new System.Drawing.Size(181, 70);
            this.cmsTreeView.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTreeView_Opening);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // lblUI1
            // 
            this.lblUI1.AutoSize = true;
            this.lblUI1.Location = new System.Drawing.Point(245, 18);
            this.lblUI1.Name = "lblUI1";
            this.lblUI1.Size = new System.Drawing.Size(61, 13);
            this.lblUI1.TabIndex = 3;
            this.lblUI1.Text = "Username:";
            // 
            // lblUI2
            // 
            this.lblUI2.AutoSize = true;
            this.lblUI2.Location = new System.Drawing.Point(245, 43);
            this.lblUI2.Name = "lblUI2";
            this.lblUI2.Size = new System.Drawing.Size(59, 13);
            this.lblUI2.TabIndex = 4;
            this.lblUI2.Text = "Password:";
            // 
            // lblUI3
            // 
            this.lblUI3.AutoSize = true;
            this.lblUI3.Location = new System.Drawing.Point(245, 67);
            this.lblUI3.Name = "lblUI3";
            this.lblUI3.Size = new System.Drawing.Size(45, 13);
            this.lblUI3.TabIndex = 5;
            this.lblUI3.Text = "Alias(*):";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(324, 140);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(127, 23);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "Add account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // cbRegion
            // 
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "BR",
            "EUNE",
            "EUW",
            "JP",
            "KR",
            "LAN",
            "LAS",
            "NA",
            "OCE",
            "PBE",
            "RU",
            "TR"});
            this.cbRegion.Location = new System.Drawing.Point(324, 89);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(134, 21);
            this.cbRegion.TabIndex = 7;
            // 
            // lblUI4
            // 
            this.lblUI4.AutoSize = true;
            this.lblUI4.Location = new System.Drawing.Point(245, 92);
            this.lblUI4.Name = "lblUI4";
            this.lblUI4.Size = new System.Drawing.Size(47, 13);
            this.lblUI4.TabIndex = 8;
            this.lblUI4.Text = "Region:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(324, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(134, 22);
            this.txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(324, 40);
            this.txtPassword.MaxLength = 128;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 22);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(324, 64);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(134, 22);
            this.txtNickname.TabIndex = 11;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.AutoSize = true;
            this.btnShowPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnShowPassword.Location = new System.Drawing.Point(461, 43);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(12, 13);
            this.btnShowPassword.TabIndex = 12;
            this.btnShowPassword.TabStop = true;
            this.btnShowPassword.Text = "?";
            this.btnShowPassword.VisitedLinkColor = System.Drawing.Color.Blue;
            this.btnShowPassword.MouseLeave += new System.EventHandler(this.btnShowPassword_MouseLeave);
            this.btnShowPassword.MouseHover += new System.EventHandler(this.btnShowPassword_MouseHover);
            // 
            // lblUI5
            // 
            this.lblUI5.AutoSize = true;
            this.lblUI5.Location = new System.Drawing.Point(245, 116);
            this.lblUI5.Name = "lblUI5";
            this.lblUI5.Size = new System.Drawing.Size(36, 13);
            this.lblUI5.TabIndex = 14;
            this.lblUI5.Text = "Rank:";
            // 
            // cbRank
            // 
            this.cbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRank.FormattingEnabled = true;
            this.cbRank.Items.AddRange(new object[] {
            "Unranked",
            "Iron",
            "Bronze",
            "Silver",
            "Gold",
            "Platinum",
            "Diamond",
            "Master",
            "Grandmaster",
            "Challenger"});
            this.cbRank.Location = new System.Drawing.Point(324, 113);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(88, 21);
            this.cbRank.TabIndex = 13;
            // 
            // cbRankDivision
            // 
            this.cbRankDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRankDivision.FormattingEnabled = true;
            this.cbRankDivision.Items.AddRange(new object[] {
            "IV",
            "III",
            "II",
            "I"});
            this.cbRankDivision.Location = new System.Drawing.Point(418, 113);
            this.cbRankDivision.Name = "cbRankDivision";
            this.cbRankDivision.Size = new System.Drawing.Size(40, 21);
            this.cbRankDivision.TabIndex = 15;
            // 
            // accList
            // 
            this.accList.ContextMenuStrip = this.cmsTreeView;
            this.accList.Dock = System.Windows.Forms.DockStyle.Left;     
            this.accList.Location = new System.Drawing.Point(0, 0);
            this.accList.MaximumHeight = 178;
            this.accList.Name = "accList";
            this.accList.Size = new System.Drawing.Size(240, 178);
            this.accList.TabIndex = 16;
            this.accList.Text = "accList1";
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 178);
            this.Controls.Add(this.accList);
            this.Controls.Add(this.cbRankDivision);
            this.Controls.Add(this.lblUI5);
            this.Controls.Add(this.cbRank);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUI4);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.lblUI3);
            this.Controls.Add(this.lblUI2);
            this.Controls.Add(this.lblUI1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAccounts";
            this.ShowIcon = false;
            this.Text = "LeagueAutologin Accounts";
            this.Load += new System.EventHandler(this.FrmAccounts_Load);
            this.cmsTreeView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsTreeView;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Label lblUI1;
        private System.Windows.Forms.Label lblUI2;
        private System.Windows.Forms.Label lblUI3;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label lblUI4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.LinkLabel btnShowPassword;
        private System.Windows.Forms.Label lblUI5;
        private System.Windows.Forms.ComboBox cbRank;
        private System.Windows.Forms.ComboBox cbRankDivision;
        private AccList accList;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
    }
}

