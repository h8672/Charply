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
    /// Interaction logic for GameMenu.xaml
    /// </summary>
    public partial class GameMenu : Window
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //TODO
            GameSave save = new GameSave();
            save.ShowDialog();
        }

        private void bntLoad_Click(object sender, RoutedEventArgs e)
        {
            //Open Continue screen, but dont close current.
            Continue load = new Continue();
            load.ShowDialog();
        }

        private void btnToMenu_Click(object sender, RoutedEventArgs e)
        {
            Window window = App.Current.MainWindow;
            App.Current.MainWindow = new Mainscreen();
            App.Current.MainWindow.Show();
            window.Close();
            Close();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
