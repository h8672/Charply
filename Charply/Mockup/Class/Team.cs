using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Class
{
    class Team
    {
        private string teamname;
        private int teamid;

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
        public int TeamID
        {
            get
            {
                return teamid;
            }
            set
            {
                teamid = value;
            }
        }
    }
}
