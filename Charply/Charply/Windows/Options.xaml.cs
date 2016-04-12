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
            if (BLGame.getGrid())
            {
                btnGrid.Content = "Grid on";
            }
            else
            {
                btnGrid.Content = "Grid off";
            }
            txtGameSpeed.Text = string.Format("{0}", BLGame.getGameSpeed());
            slidGameSizeSquare.Value = BLGame.getSquareSize();
        }

        private void slidGameSizeSquare_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BLGame.setSquareSize(slidGameSizeSquare.Value);
            testSquare.Width = 78.0 * BLGame.getSquareSize();
            testSquare.Height = 65.0 * BLGame.getSquareSize();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow = new Mainscreen();
            App.Current.MainWindow.Show();
            Close();
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            if (BLGame.getGrid())
            {
                BLGame.setGrid(false);
                btnGrid.Content = "Grid off";
            }
            else
            {
                BLGame.setGrid(true);
                btnGrid.Content = "Grid on";
            }
        }

        private void txtGameSpeed_TextChanged(object sender, TextChangedEventArgs e)
        {
            BLGame.setGameSpeed(Convert.ToInt32(txtGameSpeed.Text));
        }
    }
}
