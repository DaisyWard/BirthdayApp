using System;
using System.Globalization;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Application();
        }

        public static void Application()
        {
            string birthday;
            string answer;
            DateTime birthdayDate;
            string randomDateTime = RandomDate();
            Console.WriteLine("Hello there! Please enter your birthday dd/mm/yyyy");
            birthday = Console.ReadLine();

            try
            {
                birthdayDate = Convert.ToDateTime(birthday);
                bool isValid = CheckIfValid(birthdayDate);
                string birthdayDayInDutch = birthdayDate.ToString("dddd", new CultureInfo("nl-NL"));

                if(!isValid)
                {
                    Console.WriteLine("Seems like your birthday is in the future. Your birthday will be on a " + birthdayDayInDutch);
                } else
                {
                    Console.WriteLine("You were born on a " + birthdayDayInDutch);
                }
            }
            catch
            {
                Console.WriteLine("That is not a valid date for the app to process, try dd/mm/yyyy");
                Application();
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Here's a random date for you: " + randomDateTime);
            Console.WriteLine("--------------------------------------------");


            Console.WriteLine("Would you like to try another date? Y/N");
            answer = Console.ReadLine();
            if (answer.Contains("Y") || answer.Contains("y"))
            {
                Application();
            }
        }

        public static bool CheckIfValid(DateTime birthday)
        {
            int compare = DateTime.Compare(birthday.Date, DateTime.Now.Date); 

            if (compare == -1)
            {
                return true;
            } else if (compare == 0)
            {
                Console.WriteLine("Happy Birthday!");
                return true;
            }
            return false;
        }


        public static string RandomDate()
        {
            DateTime beginningOfTime;
            beginningOfTime = new DateTime(1990, 1, 1);

            Random rnd = new Random();
            int rndNoDays = rnd.Next(30000);

            DateTime newDate = beginningOfTime.AddDays(rndNoDays);

            int compare = DateTime.Compare(newDate, DateTime.Now);


            if (compare == 0 || compare <= 0)
            {
               string goose = newDate.ToString(" dd/MM/yyyy") + " was on a " + newDate.ToString("dddd");
               return goose;
            } else
            {
                string goose = newDate.ToString(" dd/MM/yyyy") + " is going to be on a " + newDate.ToString("dddd");
                return goose;
            }


        }
    }
}

