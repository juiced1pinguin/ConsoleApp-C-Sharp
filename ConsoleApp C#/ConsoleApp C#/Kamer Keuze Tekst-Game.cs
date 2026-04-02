using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_C_
{
    internal class Kamer_Keuze_Tekst_Game
    {
        
        public void start() 
        {
            Console.WriteLine("Je staat in de keuken. Wil je naar gang of woonkamer?");
            string keuze1 = Console.ReadLine();

            if (keuze1 == "gang")
            {
                Console.WriteLine("Je loopt de gang in. Waar wil je heen? wc of trap?");
                string keuze2 = Console.ReadLine();

                if (keuze2 == "wc")
                {
                    Console.WriteLine("Je opent de wc deur er is niks das pech volgende keer beter ig");
                }
                else if (keuze2 == "trap")
                {
                    Console.WriteLine("Je loopt de trap op je struikelt en valt. skill issue");
                }
                else
                {
                    Console.WriteLine("kies iets anders of type het beter");
                }
            }
            else if (keuze1 == "woonkamer")
            {
                Console.WriteLine("Je loopt de woonkamer in. Waar wil je heen? bank of tuin?");
                string keuze2 = Console.ReadLine();

                if (keuze2 == "bank")
                {
                    Console.WriteLine("Je gaat op de bank zitten en valt in slaap. tenminsten ben je veilig");
                }
                else if (keuze2 == "tuin")
                {
                    Console.WriteLine("Je loopt de tuin in een hond jaagt je weg.game over bruh");
                }
                else
                {
                    Console.WriteLine("tis niet mogelijk kies iets anders");
                }
            }
            else
            {
                Console.WriteLine("kan niet bro.");
            }
        }
    }
}
