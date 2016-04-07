using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply
{
    class Player
    {
        #region Attributes
        private Team team;
        private List<Building> buildings;
        private List<Soldier> soldiers;
        #endregion

        #region
        public Team Team
        {
            get { return team; }
            set { team = value; }
        }
        public List<Building> Buildings
        {
            get { return buildings; }
            set { buildings = value; }
        }
        public List<Soldier> Soldiers
        {
            get { return soldiers; }
            set { soldiers = value; }
        }
        #endregion

        #region Functions

        #endregion
    }
}
