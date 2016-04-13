using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Charply.Classes
{
    class Map
    {
        #region Attributes
        private Position size;
        private List<MapObject> mapobjects;
        private LinkedList<MapObject> maplink;
        #endregion

        #region Properties
        public Position MapSize
        {
            get { return size; }
            //set { size = value; }//tarvitaanko?
        }
        public List<MapObject> MapObjects
        {
            get { return mapobjects; }
            set { mapobjects = value; }//tarvitaanko?
        }
        public LinkedList<MapObject> MapLink
        {
            get { return maplink; }
            set { maplink = value; }
        }
        #endregion

        #region Constructors
        public Map(Position size)
        {
            this.size = size;
            mapobjects = new List<MapObject>();
            maplink = new LinkedList<MapObject>();
        }
        #endregion

        #region Functions
        public void init()
        {
            addMapObjects();
        }

        private void addMapObjects()
        {
            mapobjects.Add(new MapObject("Ground", 1, Brushes.Gray));
            mapobjects.Add(new MapObject("Grass", 1, Brushes.LightGreen));
            mapobjects.Add(new MapObject("Water", 10, Brushes.LightBlue));
            mapobjects.Add(new MapObject("Forest", 2, Brushes.Green));
            mapobjects.Add(new MapObject("Dirt", 1.2, Brushes.Brown));
        }

        public void createMap()
        {
            try
            {
                Random rnd = new Random();
                //Jos kartan teko onnistuu
                for (int y = 0; y < MapSize.Y; y++) //Row
                {
                    for (int x = 0; x < MapSize.X; x++) //Row item
                    {
                        if (mapobjects.Count > 0)
                        {
                            maplink.AddLast(mapobjects.ElementAt(rnd.Next(mapobjects.Count)));
                        }
                        else {
                            MessageBox.Show("There's no MapObjects");
                            break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to create map!");
                throw ex;
            }
            
        }

        public MapObject getMapObject(Position pos)
        {
            int listpos = size.X * (pos.Y - 1) + pos.Y;
            return maplink.ElementAt(listpos);

        }
        public LinkedList<MapObject> getMapView(Position pos, Position viewsize)
        {
            //Palauttaa näkymän listana
            LinkedList<MapObject> view = new LinkedList<MapObject>();
            /* Otettava huomioon...
             - sijainti keskellä
             - ruutujen määrä ruudulla
             - kartan ruutujen koko
             - */

            //Käydään kartta läpi rivi kerrallaan
            for (int y = pos.Y - (int)Math.Round((double)viewsize.X / 2); //Attribute
                y < (pos.Y + (int)Math.Round((double)viewsize.X / 2)); //if
                y++) //Final
            {
                //Ja etsitään riviltä silmien eteen tulevat MapObjectit
                for (int x = (pos.X - (int)Math.Round((double)viewsize.X / 2)); //Attribute
                x < (pos.X + (int)Math.Round((double)viewsize.X / 2)); //if
                x++) //Final
                {
                    //Lisätään LinkedList:n viimeiseksi kyseisellä kohdalla oleva MapObject
                    //käyttäen valmiiksi tehtyä getMapObject() functiota
                    view.AddLast(getMapObject(new Position(x, y)));
                }
            }
            return view;
        }
        #endregion
    }
}
