using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_C_
{
    internal class Tips_voor_het_weer
    {
        public void start()
        {
            Console.WriteLine("Welk weer is het? Je kunt kiezen uit: Zonnig, Regen, Bewolkt");
            string weer = Console.ReadLine();

            Console.WriteLine("Welke temperatuur is het in graden?");
            int temperatuur = Convert.ToInt32(Console.ReadLine());

            if (weer == "Zonnig")
            {
                if (temperatuur >= 20)
                {
                    Console.WriteLine("Het is zonnig en lekker warm Je hebt geen jas nodig vandaag.");
                }
                else
                {
                    Console.WriteLine("Het is zonnig maar best fris. dus trek een jas aan");
                }
            }
            else if (weer == "Regen")
            {
                if (temperatuur >= 15)
                {
                    Console.WriteLine("Het regent maar het is aan de warme kant dus doe misschien gewoon een dunne regenjas");
                }
                else
                {
                    Console.WriteLine("Het regent en het is koud. Trek een warme jas aan en blijf misschien gwn binnen");
                }
            }
            else if (weer == "Bewolkt")
            {
                if (temperatuur >= 15)
                {
                    Console.WriteLine("Het is bewolkt maar redelijk warm. Je kunt prima naar buiten misschien is een dunne jas handig");
                }
                else
                {
                    Console.WriteLine("Het is bewolkt en koud dus doe een lichtje aan en misschien de kachel.");
                }
            }
            else
            {
                Console.WriteLine("Dit is geen geldige keuze of je hebt de eerste letter niet als hoofdletter getypt.");
            }
        }

    }
}
