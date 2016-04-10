using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Classes
{
    class Team
    {
        #region Attributes
        private string teamname;
        private int teamid;
        #endregion

        #region Properties
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
        #endregion
        #region Constructors
        #endregion
        #region Functions
        #endregion
    }
}
