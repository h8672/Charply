﻿using Charply.Classes;
using Charply.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Show();
            //Put window to sleep for few seconds after showing awesome picture
            System.Threading.Thread.Sleep(5000);
            //Switch to client
            toClient();
        }

        private void toClient()
        {
            Application.Current.MainWindow = new Client();
            Application.Current.MainWindow.Show();
            Close();
        }
    }
}
