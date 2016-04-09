using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Classes
{
    class Settings
    {
        #region Attributes
        private int soldiercount;
        private double mapresources;
        #endregion

        #region Properties
        public int SoldierCount
        {
            get { return soldiercount; }
            set { soldiercount = value; }
        }
        public double MapMinerals
        {
            get { return mapresources; }
            set { mapresources = value; }
        }
        #endregion
    }
}
