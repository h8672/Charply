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

namespace Charply
{
    /// <summary>
    /// Interaction logic for NewGame.xaml
    /// </summary>
    public partial class NewGame : Window
    {
        public NewGame()
        {
            InitializeComponent();
        }

        #region BUTTONS
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opens new game when done it! (Loading screen first?)");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            //Avaa uuden GameMenu ikkunan, eli palaa takaisin
            Application.Current.MainWindow = new GameMenu();
            Application.Current.MainWindow.Show();
            Close();
        }
        #endregion

        private void slidMinerals_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtMinerals.Text = string.Format("Mineral condensation {0}%", slidMinerals.Value);
        }
    }
}
