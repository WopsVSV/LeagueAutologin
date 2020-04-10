using LeagueAutologin.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LeagueAutologin.Extension
{
    public class AccListItem
    {

        private Image _rankImage;
        private LeagueRank _rank;
        public LeagueRank Rank {
            get {
                return _rank;
            }
            set {
                _rank = value;
                if (_rank == LeagueRank.Unranked) _rankImage = Properties.Resources.Emblem_Unranked;
                if (_rank == LeagueRank.Iron) _rankImage = Properties.Resources.Emblem_Iron;
                if (_rank == LeagueRank.Bronze) _rankImage = Properties.Resources.Emblem_Bronze;
                if (_rank == LeagueRank.Silver) _rankImage = Properties.Resources.Emblem_Silver;
                if (_rank == LeagueRank.Gold) _rankImage = Properties.Resources.Emblem_Gold;
                if (_rank == LeagueRank.Platinum) _rankImage = Properties.Resources.Emblem_Platinum;
                if (_rank == LeagueRank.Diamond) _rankImage = Properties.Resources.Emblem_Diamond;
                if (_rank == LeagueRank.Master) _rankImage = Properties.Resources.Emblem_Master;
                if (_rank == LeagueRank.Grandmaster) _rankImage = Properties.Resources.Emblem_Grandmaster;
                if (_rank == LeagueRank.Challenger) _rankImage = Properties.Resources.Emblem_Challenger;
            }
        }

        public string Nickname { get; set; }
        public string Region { get; set; }
        public string RankText { get; set; }
        public Image RankImage {
            get {
                return _rankImage;
            }
        }

        public Account Account { get; private set; }

        public AccListItem(Account acc)
        {
            Account = acc;
            Nickname = acc.Nickname;
            Region = acc.Region;
            RankText = acc.Rank;
            Rank = LeagueRank.Unranked;

            if (RankText.Contains(" "))
            {
                string rank = RankText.Split(' ')[0];
                if (rank == "Iron") Rank = LeagueRank.Iron;
                if (rank == "Bronze") Rank = LeagueRank.Bronze;
                if (rank == "Silver") Rank = LeagueRank.Silver;
                if (rank == "Gold") Rank = LeagueRank.Gold;
                if (rank == "Platinum") Rank = LeagueRank.Platinum;
                if (rank == "Diamond") Rank = LeagueRank.Diamond;
            }
            else
            {
                if (RankText == "Master") Rank = LeagueRank.Master;
                if (RankText == "Grandmaster") Rank = LeagueRank.Grandmaster;
                if (RankText == "Challenger") Rank = LeagueRank.Challenger;
            }

        }


    }
}
