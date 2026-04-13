using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_C_
{
    internal class getal_raden
    {
        public void start() 
        {
            Random rnd = new Random();
            int geheim = rnd.Next(1, 11);

            Console.Write("Raad het getal (1 t/m 10): ");
            int gok = int.Parse(Console.ReadLine());

            if (gok == geheim)
            {
                Console.WriteLine("Goed");
            }
            else
            {
                Console.WriteLine("Fout het was: " + geheim);
            }

        }
    }
}
