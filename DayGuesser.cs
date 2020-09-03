using DayOfTheWeekApp.Core;
using System;

namespace DayOfTheWeekApp
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }

        public DateTimeOffset UserDateOfBirth { get; set; }

        public void IntroduceTheApplication() 
        {
            Console.WriteLine("Witam, jestem botem który potrafi wyliczyć dzień tygodnia, w którym się " +
                "urodziłeś na podstawie Twojej daty urodzin.");
        }

        public void AskUserForTheirDateOfBirth() 
        {
            Console.WriteLine("Podaj mi proszę swoją datę urodzenia:");
            var userDate = Console.ReadLine();

            var  succesed = DateTimeOffset.TryParse(userDate, out var date);
            if (succesed)
            {
                UserDateOfBirth = date;
                return;
            }
            Console.WriteLine("Zły format, podaj datę w formie mm/dd/yyyy:");
            AskUserForTheirDateOfBirth();
    }

    public void CalculateDayOfTheWeek() 
        {
        
        }
        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Urodziłeś się w " + "");
        }
    }
}
