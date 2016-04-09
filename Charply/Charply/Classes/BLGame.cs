﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Charply.Classes
{
    public class BLGame
    {
        #region Attributes
        private Map map;
        private List<Team> teams;
        private List<Player> players;
        private List<Movetype> movetypes;
        private Settings settings;
        #endregion

        #region Properties
        #endregion

        #region Functions
        #endregion

        #region StaticFunctions
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