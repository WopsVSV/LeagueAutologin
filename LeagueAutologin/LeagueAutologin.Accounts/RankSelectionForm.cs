using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeagueAutologin.Accounts
{
    public partial class RankSelectionForm : Form
    {
        public RankSelectionForm()
        {
            InitializeComponent();
        }

        private void RankSelectionForm_Load(object sender, EventArgs e)
        {
            cbRank.SelectedIndex = 0;
            cbRankDivision.SelectedIndex = 0;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string rank = cbRank.GetItemText(cbRank.SelectedItem);
            string division = cbRankDivision.GetItemText(cbRankDivision.SelectedItem);

            string accountRank;
            if (rank == "Unranked" || rank == "Master" || rank == "Grandmaster" || rank == "Challenger")
                accountRank = rank;
            else
                accountRank = rank + " " + division;

            fullRank.Text = accountRank;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
