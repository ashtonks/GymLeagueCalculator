using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymLeagueCalculator.Models;

namespace GymLeagueCalculator.Components.Pages
{
    public partial class Calculator
    {
        private Food food = new Food();
        private Time time = new Time();
        private SumFood sumFood = new SumFood();

        private string ConvertSecondsToHHMMSS(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"hh\:mm\:ss");
        }
    }
}
