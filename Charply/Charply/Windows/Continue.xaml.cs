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
    /// Interaction logic for Continue.xaml
    /// </summary>
    public partial class Continue : Window
    {
        public Continue()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            //To not close application, we need to temporarily copy old window address to Window class
            Window window = App.Current.MainWindow;
            //Make new window there
            App.Current.MainWindow = new Game();
            App.Current.MainWindow.Show();
            //And close old window.
            window.Close();
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
