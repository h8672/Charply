using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Classes
{
    class Skill
    {
        string name;
        int amount;
        int range;
        string info;

        public Skill(string name, int amount, int range, string info)
        {
            this.name = name;
            this.amount = amount;
            this.range = range;
            this.info = info;
        }
    }
}
