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
        }

        private void slidMinerals_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtMinerals.Text = slidMinerals.Value.ToString();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow = new LoadingScreen();
            App.Current.MainWindow.Show();
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
