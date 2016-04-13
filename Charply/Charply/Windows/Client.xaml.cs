using Charply.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        public Client()
        {
            InitializeComponent();
            InitThis();
        }

        private void InitThis()
        {
            txtVersion.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
            //txtBoardText.Background = Brushes.AliceBlue;
            txtBoardTitle.Text = "Alpha " + txtVersion.Text;
            txtBoardText.Text = "Game is currently in alpha version. New things are added continuously.\n"
                + " - Client window half way done, no version downloads or checks yet\n"
                + " - Mainscreen window done\n"
                + " - New game window done\n"
                + " - Options window to finish\n"
                + " - hm..\n";
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow = new Mainscreen();
            App.Current.MainWindow.Show();
            Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btnMore_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txtBoardText.Text);
        }
    }
}
