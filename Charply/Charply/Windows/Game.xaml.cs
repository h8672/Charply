using Charply.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Charply.Windows
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        List<Grid> selected;
        public Game()
        {
            InitializeComponent();
            onLoad();
        }

        public void onLoad()
        {
            /* Ruutujen koot
            //7:5.1 ruutua 1.3
            //8:5.6 ruutua 1.2
            //9:6.2 ruutua 1.1
            //10:6.75 ruutua 1.0
            //11:7.5 ruutua 0.9
            //11:8 ruutua 0.85
            //12:8.5 ruutua 0.8
            //13:9 ruutua 0.75
            //14:9.5 ruutua 0.7*/
            double kerroin = 1.3;
            int maarax = 0;
            int maaray = 0;
            if (kerroin == 1.3)
            {
                maarax = 7;
                maaray = 5;
            }
            else if (kerroin == 1.1)
            {
                maarax = 9;
                maaray = 6;
            }
            else if (kerroin == 0.85)
            {
                maarax = 11;
                maaray = 8;
            }
            else if (kerroin == 0.75)
            {
                maarax = 13;
                maaray = 9;
            }
            else {
                maarax = 11;
                maaray = 8;
            }
            //kerroin = BLGame.getMineralDensity();
            wrapMap.ItemHeight = 65 * kerroin; // 5/6 leveydestä
            wrapMap.ItemWidth = 78 * kerroin;
            for (int y = 0; y < maaray; y++)
            {
                for (int x = 0; x < maarax; x++)
                {
                    //Grid represents MapObject
                    Grid square = new Grid();
                    //border.BorderBrush = Brushes.Black;
                    square.Background = Brushes.Blue;
                    //border.BorderThickness = new Thickness(2);
                    square.Name = string.Format("Block{0}x{1}", x, y);
                    square.MouseDown += new MouseButtonEventHandler(onMapObjectSelect);

                    //If grid's are enabled in settings
                    if (BLGame.getGrid())
                    {
                        Border grid = new Border();
                        grid.BorderBrush = Brushes.Black;
                        grid.BorderThickness = new Thickness(1);
                        square.Children.Add(grid);
                    }

                    //If player has object there
                    //Team color
                    Border border = new Border();
                    border.BorderBrush = Brushes.Red;
                    border.BorderThickness = new Thickness(2);
                    border.Margin = new Thickness(3);

                    //Soldier
                    TextBlock obj = new TextBlock();
                    obj.Background = Brushes.Aqua;
                    //obj.Text = "textblock" + i;
                    obj.HorizontalAlignment = HorizontalAlignment.Center;
                    obj.VerticalAlignment = VerticalAlignment.Center;

                    square.Children.Add(border);
                    square.Children.Add(obj);

                    wrapMap.Children.Add(square);
                }
            }
            selected = new List<Grid>();
        }
        
        void onMapObjectSelect(object sender, MouseEventArgs e)
        {
            Grid grid = (Grid)sender;
            int temp = selected.IndexOf(grid);
            
            if (temp == -1 && selected.Count > 1)
            {//If selected more
                //Recolor all selects and clear list
                selected.ForEach(delegate (Grid tgrid)
                {
                    tgrid.Background = Brushes.Blue;
                });
                selected.Clear();
                //Color new select and add to list
                grid.Background = Brushes.Black;
                selected.Add(grid);
            }
            else if (temp == -1)
            {//If doesn't exist
                grid.Background = Brushes.Black;
                selected.Add(grid);
            }
            else
            {
                grid.Background = Brushes.Blue;
                selected.Remove(grid);
            }
            MessageBox.Show("You clicked " + grid.Name);
        }
    }
}
