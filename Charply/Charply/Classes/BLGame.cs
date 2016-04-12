using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Charply.Classes;

namespace Charply.Classes
{
    public class BLGame
    {
        #region Attributes
        static List<Team> teams;
        static List<Player> players;
        static List<Movetype> movetypes;
        static List<Building> buildings;
        static List<Soldier> soldiers;
        static List<Move> moves;
        static Map map;
        static Settings settings;
        static int turn;
        #endregion

        #region Properties
        public static int Turn
        {
            get { return turn; }
        }
        #endregion

        #region PublicStaticFunctions
        public static void init()
        {
            teams = new List<Team>();
            players = new List<Player>();
            movetypes = new List<Movetype>();
            buildings = new List<Building>();
            soldiers = new List<Soldier>();
            moves = new List<Move>();
            //map = new Map();
            settings = new Settings();
            settings.Difficulty = "easy";
            settings.GameSpeed = 1;
            settings.MapMinerals = 0.1;
            settings.MapSize = new Position(200, 200);
            settings.SoldierCount = 255;
            settings.SquareSize = 1.1;
            settings.Grid = true;
            turn = 0;
        }
        //SETS
        public static void setMapSize(int x, int y)
        {
            settings.MapSize = new Position(x, y);
        }
        public static void setMineralDensity(double density)
        {
            settings.MapMinerals = density;
        }
        public static void setDifficulty(string difficulty)
        {
            settings.Difficulty = difficulty;
        }
        public static void setSoldiersPerPlayer(int soldiers)
        {
            settings.SoldierCount = soldiers;
        }
        public static void setGrid(bool onoroff)
        {
            settings.Grid = onoroff;
        }
        public static void setSquareSize(double size)
        {
            settings.SquareSize = size;
        }
        public static void setGameSpeed(int speed)
        {
            settings.GameSpeed = speed;
        }
        //GETS'
        /* map size ei ole tärkeää tietää, vain view
        public static Position getMapSize()
        {
            return settings.MapSize;
        }*/
        public static double getMineralDensity()
        {
            return settings.MapMinerals;
        }
        public static string getDifficulty()
        {
            return settings.Difficulty;
        }
        public static int getSoldiersPerPlayer()
        {
            return settings.SoldierCount;
        }
        public static bool getGrid()
        {
            return settings.Grid;
        }
        public static double getSquareSize()
        {
            return settings.SquareSize;
        }
        public static int getGameSpeed()
        {
            return settings.GameSpeed;
        }
        #endregion

        #region PrivateStaticFunctions
        public static void readyGame()
        {
            createLists();
            //createmap
            //umm...
        }
        private static void createLists()
        {
            createTeams();
            createPlayers();
            createMoveTypes();
            createBuildings();

        }
        private static void createTeams()
        {
            for (int i = 0; i < 2; i++)
                teams.Add(new Team());
        }
        private static void createPlayers()
        {
            for (int i = 0; i < 2; i++)
                players.Add(new Player());
        }
        private static void createMoveTypes()
        {
            //Basic movement
            movetypes.Add(new Movetype("Walk forward", "N", 1));
            movetypes.Add(new Movetype("Strafe left", "W", Math.Sqrt(2)));
            movetypes.Add(new Movetype("Strafe right", "E", Math.Sqrt(2)));
            movetypes.Add(new Movetype("Walk backward", "S", Math.Sqrt(2)));
        }
        private static void createBuildings()
        {
            LinkedList<Skill> skills = new LinkedList<Skill>();
            //Surrender
            buildings.Add(new Building("Capital", 100, skills, 20));
            skills.Clear();
            //Create soldier
            buildings.Add(new Building("Barracks", 100, skills, 50));
        }
        private static void createSoldiers()
        {
            LinkedList<Skill> skills = new LinkedList<Skill>();
            //Gun shot
            soldiers.Add(new Soldier("Infantry", 20, skills, 3));
            //Barrel shot
            soldiers.Add(new Soldier("Tank", 50, skills, 1));
        }

        private static void createMap()
        {
            for (int y = 0; y < 10; y++)
                for (int x = 0; x < 10; x++)
                {
                    map.createMap();
                }
        }

        public static void test()
        {
            MessageBox.Show("Test BLGame static function");
        }
        public static string Version()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        #endregion
    }
}
