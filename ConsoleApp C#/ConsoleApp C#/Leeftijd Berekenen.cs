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
            Console.WriteLine("Je bent / word " + leeftijd + " jaar oud.");
        }
    }
}
