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
    /// Interaction logic for GameSave.xaml
    /// </summary>
    public partial class GameSave : Window
    {
        public GameSave()
        {
            InitializeComponent();
        }

        #region Buttons
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //TODO
            //txtSave;
            //txtComment;
            //txtdate;
            //txttime;
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion

    }
}
