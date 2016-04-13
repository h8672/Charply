using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Classes
{
    class Move
    {
        public Position a;
        public Position b;
        public int time;

        public Move(Position a, Position b, int time)
        {
            this.a = a;
            this.b = b;
            this.time = time;
        }
    }
}
