﻿using Checkers_Game.Model;
using Checkers_Game.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Game.ViewModel
{
    public class StatisticsViewModel
    {
        public List<GameStat> GameStats {  get; set; }

        public StatisticsViewModel()
        {
            GameStats = Helper.LoadStats("D:\\facultate\\an2\\sem2\\MAP\\Tema2MAP\\Checkers-Game\\Checkers-Game\\Resource\\statistics.txt");
        }
    }
}
