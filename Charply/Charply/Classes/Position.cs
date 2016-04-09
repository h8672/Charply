using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Classes
{
    class Position
    {
        #region Attributes
        private int x;
        private int y;
        #endregion
        #region
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        #endregion
        #region Functions
        public double getRange(Position target)
        {
            double range, rangex, rangey;
            rangex = X - target.X;
            rangey = Y - target.Y;
            range = Math.Sqrt(Math.Abs(Math.Pow(rangex, 2) + Math.Pow(rangey, 2)));
            return range;
        }
        #endregion
    }
}
