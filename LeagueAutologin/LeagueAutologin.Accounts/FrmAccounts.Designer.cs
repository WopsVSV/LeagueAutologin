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
            this.tvAccounts = new System.Windows.Forms.TreeView();
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
            this.cmsTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvAccounts
            // 
            this.tvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvAccounts.ContextMenuStrip = this.cmsTreeView;
            this.tvAccounts.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvAccounts.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvAccounts.HideSelection = false;
            this.tvAccounts.Location = new System.Drawing.Point(0, 0);
            this.tvAccounts.Name = "tvAccounts";
            this.tvAccounts.Size = new System.Drawing.Size(216, 154);
            this.tvAccounts.TabIndex = 0;
            this.tvAccounts.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvAccounts_NodeMouseClick);
            // 
            // cmsTreeView
            // 
            this.cmsTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.cmsTreeView.Name = "cmsTreeView";
            this.cmsTreeView.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // lblUI1
            // 
            this.lblUI1.AutoSize = true;
            this.lblUI1.Location = new System.Drawing.Point(227, 18);
            this.lblUI1.Name = "lblUI1";
            this.lblUI1.Size = new System.Drawing.Size(61, 13);
            this.lblUI1.TabIndex = 3;
            this.lblUI1.Text = "Username:";
            // 
            // lblUI2
            // 
            this.lblUI2.AutoSize = true;
            this.lblUI2.Location = new System.Drawing.Point(227, 43);
            this.lblUI2.Name = "lblUI2";
            this.lblUI2.Size = new System.Drawing.Size(59, 13);
            this.lblUI2.TabIndex = 4;
            this.lblUI2.Text = "Password:";
            // 
            // lblUI3
            // 
            this.lblUI3.AutoSize = true;
            this.lblUI3.Location = new System.Drawing.Point(227, 67);
            this.lblUI3.Name = "lblUI3";
            this.lblUI3.Size = new System.Drawing.Size(45, 13);
            this.lblUI3.TabIndex = 5;
            this.lblUI3.Text = "Alias(*):";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(306, 113);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(111, 23);
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
            this.cbRegion.Location = new System.Drawing.Point(306, 89);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(111, 21);
            this.cbRegion.TabIndex = 7;
            // 
            // lblUI4
            // 
            this.lblUI4.AutoSize = true;
            this.lblUI4.Location = new System.Drawing.Point(227, 92);
            this.lblUI4.Name = "lblUI4";
            this.lblUI4.Size = new System.Drawing.Size(47, 13);
            this.lblUI4.TabIndex = 8;
            this.lblUI4.Text = "Region:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(306, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(111, 22);
            this.txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(306, 40);
            this.txtPassword.MaxLength = 128;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(111, 22);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(306, 64);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(111, 22);
            this.txtNickname.TabIndex = 11;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.AutoSize = true;
            this.btnShowPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnShowPassword.Location = new System.Drawing.Point(418, 44);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(12, 13);
            this.btnShowPassword.TabIndex = 12;
            this.btnShowPassword.TabStop = true;
            this.btnShowPassword.Text = "?";
            this.btnShowPassword.VisitedLinkColor = System.Drawing.Color.Blue;
            this.btnShowPassword.MouseLeave += new System.EventHandler(this.btnShowPassword_MouseLeave);
            this.btnShowPassword.MouseHover += new System.EventHandler(this.btnShowPassword_MouseHover);
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 154);
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
            this.Controls.Add(this.tvAccounts);
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

        private System.Windows.Forms.TreeView tvAccounts;
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
    }
}

