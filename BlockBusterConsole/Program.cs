using BlockBuster;
using System;

namespace BlockBusterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = BlockBusterBasicFunctions.GetAllMovies();
            var oh = new OutputHelper();
            string ans;
            bool incorrect = true;

            Console.WriteLine("would you like the output as a CSV or written into the console? ( type: CSV or cons)");
          

            do {
                ans = Console.ReadLine();

                if (ans == "CSV")
                {
                    oh.WriteToCSV(b);
                    incorrect = false;
                }
                else if (ans == "cons")
                {
                    oh.WriteToConsole(b);
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("ERROR* Not a valid input please try again and type CSV or cons");
                }

            } while (incorrect);
               
        }
    }
}
