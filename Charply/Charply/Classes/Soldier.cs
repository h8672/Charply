using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Charply.Classes
{
    class Soldier : PlayerObject
    {
        #region Attributes
        private double movespeed;
        #endregion

        #region Properties
        public double MoveSpeed
        {
            get { return movespeed; }
            set { movespeed = value; }
        }
        #endregion

        #region Constructors
        public Soldier(string name, double life, LinkedList<Skill> skilllist, double movespeed) : base(name, life, skilllist)
        {
            this.movespeed = movespeed;
        }
        public Soldier(Soldier po, Position position) : base(po, position) {
            this.movespeed = po.movespeed;
        }
        #endregion

        #region Functions
        public bool Move(Position target, MapObject slot)
        {
            //Calculate range of position and target
            if (Pos.getRange(target) <= movespeed)
            {
                if (movespeed >= slot.SpeedPenalty)
                {
                    Pos = target;
                    movespeed -= slot.SpeedPenalty;
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
