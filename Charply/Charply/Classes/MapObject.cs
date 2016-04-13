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
        #region Attributes
        private Brush backgroundcolor;
        private string name;
        private double speedpenalty;
        #endregion

        #region Properties
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
        #endregion

        #region Constructors
        public MapObject(MapObject mo)
        {
            this.name = mo.Name;
            this.backgroundcolor = mo.Background;
            this.speedpenalty = mo.SpeedPenalty;
        }
        public MapObject(string name, double speedpenalty, Brush color)
        {
            this.Name = name;
            this.SpeedPenalty = speedpenalty;
            this.Background = color;
        }
        #endregion

        #region Functions

        #endregion
    }
}
