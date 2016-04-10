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
            wrapMap.Orientation = Orientation.Horizontal;
            wrapMap.HorizontalAlignment = HorizontalAlignment.Center;
            wrapMap.ItemHeight = 80;
            wrapMap.ItemWidth = 80;
            
            for(int i = 1; i < 60; i++)
            {
                //Grid represents MapObject
                Grid square = new Grid();
                //border.BorderBrush = Brushes.Black;
                square.Background = Brushes.Blue;
                //border.BorderThickness = new Thickness(2);
                square.Name = "Grid" + i;
                square.MouseDown += new MouseButtonEventHandler(onMapObjectSelect);

                //If grid's are enabled in settings
                Border grid = new Border();
                grid.BorderBrush = Brushes.Black;
                grid.BorderThickness = new Thickness(1);
                square.Children.Add(grid);

                //If player has object there
                //Team color
                Border border = new Border();
                border.BorderBrush = Brushes.Red;
                border.BorderThickness = new Thickness(5);
                border.Margin = new Thickness(3);

                //Soldier
                TextBlock obj = new TextBlock();
                obj.Background = Brushes.Aqua;
                obj.Text = "textblock" + i;
                obj.HorizontalAlignment = HorizontalAlignment.Center;
                obj.VerticalAlignment = VerticalAlignment.Center;

                square.Children.Add(border);
                square.Children.Add(obj);
                
                wrapMap.Children.Add(square);
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
