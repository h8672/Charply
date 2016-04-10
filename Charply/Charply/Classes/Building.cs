using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Classes
{
    class Building
    {
        #region Attributes
        private Position pos;
        private double life;
        private string name;
        private string direction;
        private string info;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
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

        #region Functions

        #endregion
    }
}
