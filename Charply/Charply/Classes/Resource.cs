using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Classes
{
    class Resource
    {
        #region Attributes
        private string name;
        private int amount;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
        }
        public int Amount
        {
            get { return amount; }
        }
        #endregion

        #region Constructors
        public Resource(string name, int amount)
        {
            this.name = name;
            this.amount = amount;
        }
        #endregion

        #region Functions

        #endregion
    }
}
