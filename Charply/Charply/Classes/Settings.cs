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
        //Options
        private int gamespeed;
        private double mapsquaresize;
        //New game
        private Position mapsize;
        private double mapresources;
        private string difficulty;
        private int soldiercount;
        private bool grid;
        #endregion

        #region Properties
        //Options
        public int GameSpeed {
            get{ return gamespeed; }
            set { gamespeed = value; }
        }
        public double SquareSize
        {
            get { return mapsquaresize; }
            set { mapsquaresize = value; }
        }
        public bool Grid
        {
            get { return grid; }
            set { grid = value; }
        }
        //New game
        public Position MapSize
        {
            get { return mapsize; }
            set { mapsize = value; }
        }
        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
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
