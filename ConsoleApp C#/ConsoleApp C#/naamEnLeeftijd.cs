using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_C_
{
    internal class naamEnLeeftijd
    {
       public void Start()
        {
            Console.WriteLine("Typ je naam:");
            string naam = Console.ReadLine();
            Console.WriteLine("Typ je leeftijd:");
            string leeftijd = Console.ReadLine();
            Console.WriteLine($"Hoi {naam}, je bent {leeftijd} jaar oud!");
        }
    }
}
