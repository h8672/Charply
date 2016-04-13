using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Classes
{
    static class Settings
    {
        #region Attributes
        //Options
        static private int gamespeed;
        static private double mapsquaresize;
        //New game
        static private Position mapsize;
        static private double mapresources;
        static private string difficulty;
        static private int soldiercount;
        static private bool grid;
        #endregion

        #region Properties
        //Options
        static public int GameSpeed {
            get{ return gamespeed; }
            set { gamespeed = value; }
        }
        static public double SquareSize
        {
            get { return mapsquaresize; }
            set { mapsquaresize = value; }
        }
        static public bool Grid
        {
            get { return grid; }
            set { grid = value; }
        }
        //New game
        static public Position MapSize
        {
            get { return mapsize; }
            set { mapsize = value; }
        }
        static public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }
        static public int SoldierCount
        {
            get { return soldiercount; }
            set { soldiercount = value; }
        }
        static public double MapMinerals
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
