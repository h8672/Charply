using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Class
{
    class MapObject
    {
        private string name;
        private double movementcost;
        private string background;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double MoveCost
        {
            get { return movementcost; }
            set { movementcost = value; }
        }
        public string Background
        {
            get { return background; }
            set { background = value; }
        }
    }
}
