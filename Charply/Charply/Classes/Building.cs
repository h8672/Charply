using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Classes
{
    class Building : PlayerObject
    {
        #region Attributes
        private int armor;
        #endregion

        #region Properties
        public int Armor
        {
            get { return armor; }
        }
        #endregion

        #region Constructors
        public Building(string name, double life, LinkedList<Skill> skilllist, int armor) : base(name, life, skilllist)
        {
            this.armor = armor;
        }
        public Building(Building po, Position position) : base(po, position) { }
        #endregion

        #region Functions
        #endregion
    }
}
