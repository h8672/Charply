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
    /// Interaction logic for Mainscreen.xaml
    /// </summary>
    public partial class Mainscreen : Window
    {
        public Mainscreen()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow = new NewGame();
            App.Current.MainWindow.Show();
            Close();
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            Continue load = new Continue();
            load.ShowDialog();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow = new Options();
            App.Current.MainWindow.Show();
            Close();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, Charply is a studywork for C# course and is made by Juha-Matti Kokkonen. It is a turnbased strategy game and code is opensource and is located in https://github.com/h8672/Charply");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
