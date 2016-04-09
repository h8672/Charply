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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Charply
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GameMenu : Window
    {
        Settings settings;
        public GameMenu()
        {
            InitializeComponent();
            Initstuff();
        }
        private void Initstuff()
        {
            //Initialize function
            //SetStatusMessage("Error: statusbar test is not showing!");
        }
        
        private void SetStatusMessage(string message)
        {
            barStatus.Text = message;
            barStatus.Visibility = Visibility.Visible;
        }

        #region Buttons
        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            //Opens NewGame window
            Application.Current.MainWindow = new NewGame();
            Application.Current.MainWindow.Show();
            settings.Close();
            Close();
        }
        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            //TODO
            Application.Current.MainWindow = new Continue();
            Application.Current.MainWindow.Show();
            settings.Close();
            Close();
        }
        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Option for game");
            settings = new Settings();
            settings.Show();
        }
        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello from About button!\nCheck https://github.com/h8672/Charply/wiki/Charply");
            //Application.Current.MainWindow = new NewGame();
            //Application.Current.MainWindow.Show();
            //Close();
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion
        
    }
}
