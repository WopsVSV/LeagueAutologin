namespace LeagueAutologin.Accounts
{
    partial class RankSelectionForm
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
            this.cbRankDivision = new System.Windows.Forms.ComboBox();
            this.cbRank = new System.Windows.Forms.ComboBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.fullRank = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.cbRankDivision.Location = new System.Drawing.Point(106, 12);
            this.cbRankDivision.Name = "cbRankDivision";
            this.cbRankDivision.Size = new System.Drawing.Size(40, 21);
            this.cbRankDivision.TabIndex = 18;
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
            this.cbRank.Location = new System.Drawing.Point(12, 12);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(88, 21);
            this.cbRank.TabIndex = 17;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(12, 39);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(134, 23);
            this.btnAddAccount.TabIndex = 16;
            this.btnAddAccount.Text = "Change rank";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // fullRank
            // 
            this.fullRank.AutoSize = true;
            this.fullRank.Location = new System.Drawing.Point(0, 0);
            this.fullRank.Name = "fullRank";
            this.fullRank.Size = new System.Drawing.Size(35, 13);
            this.fullRank.TabIndex = 19;
            this.fullRank.Text = "label1";
            this.fullRank.Visible = false;
            // 
            // RankSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 69);
            this.Controls.Add(this.fullRank);
            this.Controls.Add(this.cbRankDivision);
            this.Controls.Add(this.cbRank);
            this.Controls.Add(this.btnAddAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RankSelectionForm";
            this.ShowIcon = false;
            this.Text = "Select rank";
            this.Load += new System.EventHandler(this.RankSelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRankDivision;
        private System.Windows.Forms.ComboBox cbRank;
        private System.Windows.Forms.Button btnAddAccount;
        public System.Windows.Forms.Label fullRank;
    }
}