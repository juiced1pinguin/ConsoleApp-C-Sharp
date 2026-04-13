using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_C_
{
    internal class Leeftijd_Berekenen
    {
        public void start() 
        {
            Console.Write("Geboortejaar: ");
            int jaar = int.Parse(Console.ReadLine());
            int leeftijd = DateTime.Now.Year - jaar;
            Console.WriteLine("Je bent " + leeftijd + " jaar oud.");
            if (leeftijd >= 18)
            {
                Console.WriteLine("Je bent 18+ en je mag stemmen.");
            }
            else
            {
                Console.WriteLine("Je bent nog geen 18 en je mag nog niet stemmen.");
            }

        }
    }
}
