using System;
namespace FlytHjemmefra
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); 
                Console.WriteLine("Velkommen Velkommen til Ungeråd’s Flyt hjemmefra-service."); 
                Console.WriteLine("Hvad er dit navn?");
                string navn = Console.ReadLine(); 
                Console.Write("Indtast din timeløn: ");
                string timeløn = Console.ReadLine();
                Console.Write("Hvor mange timer arbejder du om ugen: ");
                string timer = Console.ReadLine();
                double ugeløn = Convert.ToDouble(timeløn) * Convert.ToDouble(timer);
                double amount = 0;
                double maxløn = ugeløn; 
                Console.WriteLine($"Hej {navn} Du tjener {ugeløn} om ugen."); 

                while (maxløn > 0) 
                {
                    amount = amount + 1; 
                    if (amount == 100)
                    {
                        Console.Write("*");
                        amount = 0;
                    }
                    maxløn = maxløn - 1;
                   
                }

                if (ugeløn > 2600)
                {
                    Console.WriteLine("\nDu har råd til at flytte hjemmefra.");
                }
                else
                {
                    Console.WriteLine("\nDu har ikke råd til at flytte hjemmefra.");
                }
                Console.ReadKey();

            } while (true); 

        }
    }
}
