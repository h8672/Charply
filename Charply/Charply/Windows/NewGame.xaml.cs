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
    /// Interaction logic for NewGame.xaml
    /// </summary>
    public partial class NewGame : Window
    {
        public NewGame()
        {
            InitializeComponent();

            cbDifficulty.Items.Add("Easy");
            cbDifficulty.Items.Add("Medium");
            cbDifficulty.Items.Add("Hard");
            cbDifficulty.SelectedIndex = 0;
        }

        private void slidMinerals_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtMinerals.Text = "Mineral dentisity " + slidMinerals.Value.ToString() + " %";
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            string difficulty;
            switch (cbDifficulty.SelectedIndex) {
                case 0:
                    difficulty = "easy";
                    break;
                case 1:
                    difficulty = "easy";
                    break;
                case 2:
                    difficulty = "easy";
                    break;
                default:
                    difficulty = "easy";
                    break;
            }
            BLGame.setDifficulty(difficulty);
            BLGame.setMapSize(Convert.ToInt32(txtMapWidth.Text), Convert.ToInt32(txtMapHeight.Text));
            BLGame.setMineralDensity((double)slidMinerals.Value / 100);
            BLGame.setSoldiersPerPlayer(Convert.ToInt32(txtSoldiers.Text));
            App.Current.MainWindow = new LoadingScreen();
            //App.Current.MainWindow.Show();
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow = new Mainscreen();
            App.Current.MainWindow.Show();
            Close();
        }
    }
}
