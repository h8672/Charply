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
    /// Interaction logic for TeamPlayer.xaml
    /// </summary>
    public partial class TeamPlayer : Window
    {
        public TeamPlayer()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Settings.PlayerName = txtPlayerName.Text;
            Settings.Cpu = Convert.ToInt32(txtCPUs.Text);
            Settings.Teams = Convert.ToInt32(txtTeams.Text);
            Settings.Solo = cbSolo.IsChecked.Value;
            Close();
        }
    }
}
