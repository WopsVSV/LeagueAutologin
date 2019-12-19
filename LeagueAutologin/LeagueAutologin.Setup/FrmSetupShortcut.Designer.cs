namespace LeagueAutologin.Setup
{
    partial class FrmSetupShortcut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetupShortcut));
            this.lblUI1 = new System.Windows.Forms.Label();
            this.txtLeagueClientLocation = new System.Windows.Forms.TextBox();
            this.btnSelectLeagueClient = new System.Windows.Forms.Button();
            this.btnCreateShortcut = new System.Windows.Forms.Button();
            this.btnSetupAccounts = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUI1
            // 
            this.lblUI1.AutoSize = true;
            this.lblUI1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUI1.Location = new System.Drawing.Point(21, 21);
            this.lblUI1.Name = "lblUI1";
            this.lblUI1.Size = new System.Drawing.Size(126, 15);
            this.lblUI1.TabIndex = 0;
            this.lblUI1.Text = "League client location:";
            // 
            // txtLeagueClientLocation
            // 
            this.txtLeagueClientLocation.Location = new System.Drawing.Point(24, 39);
            this.txtLeagueClientLocation.Name = "txtLeagueClientLocation";
            this.txtLeagueClientLocation.ReadOnly = true;
            this.txtLeagueClientLocation.Size = new System.Drawing.Size(186, 22);
            this.txtLeagueClientLocation.TabIndex = 1;
            // 
            // btnSelectLeagueClient
            // 
            this.btnSelectLeagueClient.Location = new System.Drawing.Point(216, 39);
            this.btnSelectLeagueClient.Name = "btnSelectLeagueClient";
            this.btnSelectLeagueClient.Size = new System.Drawing.Size(28, 21);
            this.btnSelectLeagueClient.TabIndex = 2;
            this.btnSelectLeagueClient.Text = "...";
            this.btnSelectLeagueClient.UseVisualStyleBackColor = true;
            this.btnSelectLeagueClient.Click += new System.EventHandler(this.btnSelectLeagueClient_Click);
            // 
            // btnCreateShortcut
            // 
            this.btnCreateShortcut.Location = new System.Drawing.Point(24, 65);
            this.btnCreateShortcut.Name = "btnCreateShortcut";
            this.btnCreateShortcut.Size = new System.Drawing.Size(110, 23);
            this.btnCreateShortcut.TabIndex = 3;
            this.btnCreateShortcut.Text = "Create shortcut";
            this.btnCreateShortcut.UseVisualStyleBackColor = true;
            this.btnCreateShortcut.Click += new System.EventHandler(this.btnCreateShortcut_Click);
            // 
            // btnSetupAccounts
            // 
            this.btnSetupAccounts.Location = new System.Drawing.Point(140, 65);
            this.btnSetupAccounts.Name = "btnSetupAccounts";
            this.btnSetupAccounts.Size = new System.Drawing.Size(104, 23);
            this.btnSetupAccounts.TabIndex = 4;
            this.btnSetupAccounts.Text = "Setup accounts";
            this.btnSetupAccounts.UseVisualStyleBackColor = true;
            this.btnSetupAccounts.Click += new System.EventHandler(this.btnSetupAccounts_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.AutoSize = true;
            this.btnHelp.Location = new System.Drawing.Point(23, 91);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(133, 13);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.TabStop = true;
            this.btnHelp.Text = "Don\'t know what to do?";
            this.btnHelp.VisitedLinkColor = System.Drawing.Color.Blue;
            this.btnHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnHelp_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 130);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // FrmSetupShortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 115);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSetupAccounts);
            this.Controls.Add(this.btnCreateShortcut);
            this.Controls.Add(this.btnSelectLeagueClient);
            this.Controls.Add(this.txtLeagueClientLocation);
            this.Controls.Add(this.lblUI1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmSetupShortcut";
            this.ShowIcon = false;
            this.Text = "LeagueAutologin Setup";
            this.Load += new System.EventHandler(this.FrmSetupShortcut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUI1;
        private System.Windows.Forms.TextBox txtLeagueClientLocation;
        private System.Windows.Forms.Button btnSelectLeagueClient;
        private System.Windows.Forms.Button btnCreateShortcut;
        private System.Windows.Forms.Button btnSetupAccounts;
        private System.Windows.Forms.LinkLabel btnHelp;
        private System.Windows.Forms.Label label2;
    }
}

