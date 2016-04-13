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
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
            if (Settings.Grid)
            {
                btnGrid.Content = "Grid on";
            }
            else
            {
                btnGrid.Content = "Grid off";
            }
            txtGameSpeed.Text = string.Format("{0}", Settings.GameSpeed);
            slidGameSizeSquare.Value = Settings.SquareSize;
        }

        private void txtGameSpeed_TextChanged(object sender, TextChangedEventArgs e)
        {
            Settings.GameSpeed = Convert.ToInt32(txtGameSpeed.Text);
        }

        private void slidChange()
        {
            Settings.SquareSize = slidGameSizeSquare.Value;
            testSquare.Width = 78.0 * Settings.SquareSize;
            testSquare.Height = 65.0 * Settings.SquareSize;
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            if (Settings.Grid)
            {
                Settings.Grid = false;
                btnGrid.Content = "Grid off";
            }
            else
            {
                Settings.Grid = true;
                btnGrid.Content = "Grid on";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow = new Mainscreen();
            App.Current.MainWindow.Show();
            Close();
        }

        private void slidGameSizeSquare_DragCompleted(object sender, RoutedEventArgs e)
        {
            slidChange();
        }

        private void slidGameSizeSquare_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.IsDown && (e.Key == Key.Left || e.Key == Key.Right))
                slidChange();
        }
    }
}
