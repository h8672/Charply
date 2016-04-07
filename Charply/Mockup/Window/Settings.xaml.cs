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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            txtGameSizeSquare.Text = "";
            string Ticks = "1";
            Double tick = 0.2;
            for(Double i = 1 + tick; i < 5;)
            {
                Ticks = string.Format("{0}, {1}", Ticks, i.ToString(System.Globalization.CultureInfo.InvariantCulture)); //So decimals will use dot!
                i += tick;
            }
            slidGameSizeSquare.Ticks = DoubleCollection.Parse(Ticks);
            //MessageBox.Show(Ticks);
        }

        private void slidGameSizeSquare_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtGameSizeSquare.Text = string.Format("{0}", slidGameSizeSquare.Value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
