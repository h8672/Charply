using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Charply.Classes
{
    class Movetype
    {
        #region Attributes
        private string name;
        private string direction;
        private double speedpenalty;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Direction{
            get { return direction; }
            set
            {
                if (0 < value.Length && value.Length < 3)
                {
                    this.direction = value;
                }
                else
                {
                    MessageBox.Show("Suuntaa " + value + " ei voitu sijoittaa Movetype classiin nimeltä " + this.name);
                }
            }
        }
        #endregion

        #region Constructors
        public Movetype(string name, string direction, double speedpenalty)
        {
            this.Name = name;
            this.Direction = direction;
        }
        #endregion

        #region Functions
        #endregion
    }
}
