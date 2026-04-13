using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_C_
{
    internal class Tafels_Generator
    {
        public void start() 
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("5 x " + i + " = " + (5 * i));
            }

        }
    }
}
