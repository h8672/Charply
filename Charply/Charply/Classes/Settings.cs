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
        //From options
        private int gamespeed;
        private double mapsquaresize;
        //From new game
        private Position mapsize;
        private double mapresources;
        private int difficulty;
        private int soldiercount;
        #endregion

        #region Properties
        public int GameSpeed {
            get{ return gamespeed; }
            set { gamespeed = value; }
        }
        public double SquareSize
        {
            get { return mapsquaresize; }
            set { mapsquaresize = value; }
        }
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

        #region Constructors

        #endregion

        #region Functions

        #endregion
    }
}
