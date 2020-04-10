namespace LeagueAutologin.Extension
{
    partial class FrmWidget
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
            this.btnClose = new System.Windows.Forms.Label();
            this.tmrCheckScreen = new System.Windows.Forms.Timer(this.components);
            this.tmrCheckProcess = new System.Windows.Forms.Timer(this.components);
            this.tmrRelocateForm = new System.Windows.Forms.Timer(this.components);
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.accList = new LeagueAutologin.Extension.AccList();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(126, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(12, 13);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "x";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tmrCheckScreen
            // 
            this.tmrCheckScreen.Interval = 500;
            this.tmrCheckScreen.Tick += new System.EventHandler(this.tmrCheckScreen_Tick);
            // 
            // tmrCheckProcess
            // 
            this.tmrCheckProcess.Interval = 250;
            this.tmrCheckProcess.Tick += new System.EventHandler(this.tmrCheckProcess_Tick);
            // 
            // tmrRelocateForm
            // 
            this.tmrRelocateForm.Interval = 150;
            this.tmrRelocateForm.Tick += new System.EventHandler(this.tmrRelocateForm_Tick);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounts.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAccounts.Location = new System.Drawing.Point(0, 699);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(254, 21);
            this.btnAccounts.TabIndex = 15;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReload.Location = new System.Drawing.Point(0, 678);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(254, 21);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // accList
            // 
            this.accList.Location = new System.Drawing.Point(0, 0);
            this.accList.MaximumHeight = 672;
            this.accList.Name = "accList";
            this.accList.Size = new System.Drawing.Size(240, 672);
            this.accList.TabIndex = 17;
            this.accList.Text = "accList2";
            this.accList.DoubleClick += new System.EventHandler(this.accList_DoubleClick);
            // 
            // FrmWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(254, 720);
            this.Controls.Add(this.accList);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnAccounts);
            this.Controls.Add(this.btnClose);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWidget";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.Text = "LeagueAutologin";
            this.Load += new System.EventHandler(this.FrmWidget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Timer tmrCheckScreen;
        private System.Windows.Forms.Timer tmrCheckProcess;
        private System.Windows.Forms.Timer tmrRelocateForm;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnReload;
        private AccList accList1;
        private AccList accList;
    }
}

