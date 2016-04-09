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
        private string name;
        private Position pos;
        #endregion

        #region
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
