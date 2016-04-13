using Charply.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        List<Team> teams;
        List<Player> players;
        List<Building> buildings;
        List<Soldier> soldiers;
        Map map;
        int turn;

        List<Grid> selected;
        //View position
        Position view;

        //Window key listener
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.IsRepeat)
            {
                if (e.Key == Key.Up)
                {
                    view.Y--;
                }
                if (e.Key == Key.Down)
                {
                    view.Y++;
                }
                if (e.Key == Key.Left)
                {
                    view.X--;
                }
                if (e.Key == Key.Right)
                {
                    view.X++;
                }
                updateWindow();
            }
        }

        public Game()
        {
            InitializeComponent();
            onLoad();
        }

        private void initLists()
        {
            teams = new List<Team>();
            players = new List<Player>();
            buildings = new List<Building>();
            soldiers = new List<Soldier>();
            map = new Map(Settings.MapSize);
            turn = 0;
            //View position
            view = new Position(0, 0);
            //Collects selections
            selected = new List<Grid>();
        }
        private void addItemsToLists()
        {
            teams.Add(new Team());
            players.Add(new Player());

            LinkedList<Skill> skills = new LinkedList<Skill>();
            /* Buildings */
            //Capital
            skills.AddLast(new Skill("Surrender", 0, 0, "Want to surrender?"));
            buildings.Add(new Building("Capital", 100, skills, 20));
            skills.Clear();
            //Barracks
            skills.AddLast(new Skill("Create Engineer", 1, 0, "Create an engineer"));
            skills.AddLast(new Skill("Create Soldier", 1, 0, "Create a soldier"));
            skills.AddLast(new Skill("Create Tank", 1, 0, "Create a tank"));
            buildings.Add(new Building("Barracks", 100, skills, 50));
            skills.Clear();

            /* People */
            //Engineer
            skills.AddLast(new Skill("Build Capital", 1, 0, "Capital, the structure you want to protect"));
            skills.AddLast(new Skill("Build Barracks", 1, 0, "Barracks creates soldiers"));
            skills.AddLast(new Skill("Repair", 5, 0, "Repair buildings and vehicles"));
            soldiers.Add(new Soldier("Engineer", 25, skills, 2));
            skills.Clear();
            //Medic
            skills.AddLast(new Skill("Heal", 5, 1, "Heals people"));
            soldiers.Add(new Soldier("Medic", 25, skills, 2));
            skills.Clear();
            //Infantry
            skills.AddLast(new Skill("Gun shot", 10, 1, "Attack with gun"));
            soldiers.Add(new Soldier("Infantry", 50, skills, 3));
            skills.Clear();

            /* Vehicles */
            //Jeep
            skills.AddLast(new Skill("Machinegun shots", 20, 2, "Attack with machine gun"));
            soldiers.Add(new Soldier("Jeep", 100, skills, 1));
            skills.Clear();
            //Tank
            skills.AddLast(new Skill("Barrel shot", 30, 3, "Attack, shoots 50% through buildings armor"));
            soldiers.Add(new Soldier("Tank", 150, skills, 1));
            skills.Clear();

            //map.createMap();
        }
        private void updateWindow()
        {
            /* Ruutujen koot
            //7:5.1 ruutua 1.3
            //8:5.6 ruutua 1.2
            //9:6.2 ruutua 1.1
            //10:6.75 ruutua 1.0
            //11:7.5 ruutua 0.9
            //11:8 ruutua 0.85
            //12:8.5 ruutua 0.8
            //13:9 ruutua 0.75
            //14:9.5 ruutua 0.7*/
            double kerroin = 1.3;
            int maarax = 0;
            int maaray = 0;
            if (kerroin == 1.3)
            {
                maarax = 7;
                maaray = 5;
            }
            else if (kerroin == 1.1)
            {
                maarax = 9;
                maaray = 6;
            }
            else if (kerroin == 0.85)
            {
                maarax = 11;
                maaray = 8;
            }
            else if (kerroin == 0.75)
            {
                maarax = 13;
                maaray = 9;
            }
            else {
                maarax = 11;
                maaray = 8;
            }
            //kerroin = BLGame.getMineralDensity();
            wrapMap.ItemHeight = 65 * kerroin; // 5/6 leveydestä
            wrapMap.ItemWidth = 78 * kerroin;
            for (int y = 0; y < maaray; y++)
            {
                for (int x = 0; x < maarax; x++)
                {
                    //Grid represents MapObject
                    Grid square = new Grid();
                    //border.BorderBrush = Brushes.Black;
                    square.Background = Brushes.Blue;
                    //border.BorderThickness = new Thickness(2);
                    square.Name = string.Format("Block{0}x{1}", x, y);
                    square.MouseDown += new MouseButtonEventHandler(onMapObjectSelect);

                    //If grid's are enabled in settings
                    if (Settings.Grid)
                    {
                        Border grid = new Border();
                        grid.BorderBrush = Brushes.Black;
                        grid.BorderThickness = new Thickness(1);
                        square.Children.Add(grid);
                    }

                    //If player has object there
                    //Team color
                    Border border = new Border();
                    border.BorderBrush = Brushes.Red;
                    border.BorderThickness = new Thickness(2);
                    border.Margin = new Thickness(3);

                    //Soldier
                    TextBlock obj = new TextBlock();
                    obj.Background = Brushes.Aqua;
                    //obj.Text = "textblock" + i;
                    obj.HorizontalAlignment = HorizontalAlignment.Center;
                    obj.VerticalAlignment = VerticalAlignment.Center;

                    square.Children.Add(border);
                    square.Children.Add(obj);

                    wrapMap.Children.Add(square);
                }
            }
        }

        public void onLoad()
        {
            initLists();
            addItemsToLists();
            updateWindow();
        }

        //Click wrapmap object
        void onMapObjectSelect(object sender, MouseEventArgs e)
        {
            Grid grid = (Grid)sender;
            int temp = selected.IndexOf(grid);
            
            if (temp == -1 && selected.Count > 1)
            {//If selected more
                //Recolor all selects and clear list
                string[] numbers;
                selected.ForEach(delegate (Grid tgrid)
                {
                    tgrid.Background = Brushes.Blue;

                    numbers = Regex.Split(tgrid.Name, @"\D+");
                });

                selected.Clear();
                //Color new select and add to list
                grid.Background = Brushes.Black;
                selected.Add(grid);
            }
            else if (temp == -1)
            {//If doesn't exist
                grid.Background = Brushes.Black;
                selected.Add(grid);
            }
            else
            {
                grid.Background = Brushes.Blue;
                selected.Remove(grid);
            }
            MessageBox.Show("You clicked " + grid.Name);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtTurns.Text = string.Format("{0}", ++turn);

        }
    }
}
