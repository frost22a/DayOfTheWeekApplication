using DayOfTheWeekApp.Core;
using System;

namespace DayOfTheWeekApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var guesser = new DayGuesser();
            guesser.IntroduceTheApplication();
            guesser.AskUserForTheirDateOfBirth();
            guesser.CalculateDayOfTheWeek();
            guesser.PrintDayOfTheWeek();
        }
    }
}
