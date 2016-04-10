using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Charply.Classes
{
    class Soldier
    {
        #region Attributes
        private double movespeed;
        Position pos;
        #endregion

        #region Properties
        public double MoveSpeed
        {
            get { return movespeed; }
            set { movespeed = value; }
        }
        public int X
        {
            get { return pos.X; }
            set { pos.X = value; }
        }
        public int Y
        {
            get { return pos.Y; }
            set { pos.Y = value; }
        }
        #endregion

        #region Constructors

        #endregion

        #region Functions
        public bool Move(Position target, MapObject slot)
        {
            //Calculate range of position and target
            if (pos.getRange(target) <= movespeed)
            {
                if (movespeed >= slot.SpeedPenalty)
                {
                    pos = target;
                    return true;
                }
                else { return false; }
            }
            else {
                MessageBox.Show("Movement cost too high to move there");
                return false;
            }
        }
        #endregion
    }
}
