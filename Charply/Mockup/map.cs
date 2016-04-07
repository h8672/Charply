using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply
{
    class Map
    {
        private Position mapsize;
        private List<MapObject> mapobjects;

        public Position MapSize {
            get { return mapsize; }
            set { mapsize = value; }//tarvitaanko?
        }
        public List<MapObject> MapObjects
        {
            get{ return mapobjects; }
            set{ mapobjects = value; }//tarvitaanko?
        }

        public MapObject getMapObject(Position pos)
        {
            int listpos = mapsize.X * (pos.Y - 1) + pos.Y;
            return mapobjects.ElementAt(listpos);
            
        }
    }
}
