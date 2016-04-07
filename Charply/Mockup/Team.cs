using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply
{
    class Team
    {
        private string teamname;
        List<Building> buildings;
        List<Soldier> soldiers;

        public string TeamName
        {
            get
            {
                return teamname;
            }
            set
            {
                teamname = value;
            }
        }
    }
}
