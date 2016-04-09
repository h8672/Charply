using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Charply.Classes
{
    class MapObject
    {
        private Brush backgroundcolor;
        private string name;
        private double speedpenalty;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double SpeedPenalty
        {
            get { return speedpenalty; }
            set { speedpenalty = value; }
        }
        public Brush Background
        {
            get { return backgroundcolor; }
            set { backgroundcolor = value; }
        }

        public MapObject(string name, double speedpenalty, Brush color)
        {
            this.Name = name;
            this.SpeedPenalty = speedpenalty;
            this.Background = color;
        }
    }
}
