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
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        public Client()
        {
            InitializeComponent();

        }

        static public void Test()
        {
            MessageBox.Show("Test!");
        }

        #region Buttons
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            /*Application.Current.MainWindow = new GameMenu();
            Application.Current.MainWindow.Show();
            Close(); //Without client window stays open*/
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        #endregion
    }
}
