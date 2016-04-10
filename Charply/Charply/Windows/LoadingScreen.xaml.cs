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
    /// Interaction logic for LoadingScreen.xaml
    /// </summary>
    public partial class LoadingScreen : Window
    {
        public LoadingScreen()
        {
            InitializeComponent();
            mystuff();
        }

        public void mystuff()
        {
            List<LoadingText> texts = new List<LoadingText>();
            texts.Add(new LoadingText("Hello"));
            texts.Add(new LoadingText("text"));
            texts.Add(new LoadingText("of"));
            texts.Add(new LoadingText("loading"));
            texts.Add(new LoadingText("screen"));
            texts.Add(new LoadingText("before"));
            texts.Add(new LoadingText("game"));
            gridLoading.ItemsSource = texts;
            this.Show();
            System.Threading.Thread.Sleep(2000);
            App.Current.MainWindow = new Game();
            App.Current.MainWindow.Show();
            Close();
        }

        public class LoadingText {
            public string text { get; set; }

            public LoadingText(string input)
            {
                this.text = input;
            }
        }
    }
}
