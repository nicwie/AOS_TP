using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_TP
{
    internal class Match
    {
        private string aus_army;
        private string opp_army;
        private string mission;
        private double rating;

        public Match (string aus_army, string opp_army, string mission, double aus_mission_rating, double opp_mission_rating, double mu_rating)
        {
            this.aus_army = aus_army;
            this.opp_army = opp_army;
            this.mission = mission;

            rating = -3.5 + aus_mission_rating + opp_mission_rating + mu_rating;
        }

        public double getRating()
        {
            return rating;
        }
    }
}
