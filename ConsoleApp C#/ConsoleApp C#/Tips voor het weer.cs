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
            Console.WriteLine("welk weer is het je kunt kiezen uit: Zonnig, Regen, Bewolkt");
            string weer = Console.ReadLine();

            if(weer == "Zonnig") 
            {
                Console.WriteLine("het is zonnig buiten ga eens een stuk lopen");
            }
            else if(weer == "Regen") 
            {
                Console.WriteLine("het is regenachtig misschien als je moet slapen kan je beter in slaap vallen");
            }
            else if(weer == "Bewolkt") 
            {
                Console.WriteLine("het is bewolkt en dus donker dus doe een lichtje aan en maak het gezellig ofzo");
            }
            else 
            {
                Console.WriteLine("dis is geen geldige keuze of je had de eerste letter niet als hoofdletter getypt");
            }
        }
    }
}
