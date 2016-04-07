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
    /// Interaction logic for Continue.xaml
    /// </summary>
    public partial class Continue : Window
    {
        public Continue()
        {
            InitializeComponent();
        }

        #region BUTTONS
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            //Käynnistä peli, lataa kartta tiedot ja päivittää ne tallennuksen tasolle
            //Application.Current.MainWindow = new NewGame();
            //Application.Current.MainWindow.Show();
            //Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            //Menee takaisin GameMenuun
            Application.Current.MainWindow = new GameMenu();
            Application.Current.MainWindow.Show();
            Close();
        }
        #endregion
    }
}
