using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_C_
{
    internal class DobbelsteenGooien
    {
        public void start()
        {
            Random rnd = new Random();
            for (int i = 1; i <= 100; i++)
            {
                int aantal_1 = 0;
                int aantal_2 = 0;
                int aantal_3 = 0;
                int aantal_4 = 0;
                int aantal_5 = 0;
                int aantal_6 = 0;
                int dobbelsteen = rnd.Next(1, 7);

                if(dobbelsteen < 7)
                {
                    Console.WriteLine(dobbelsteen);
                }

                if(dobbelsteen == 1)
                {
                    aantal_1 =+ 1;
                } else if (dobbelsteen == 2)
                {
                    aantal_2 =+ 1;
                } else if (dobbelsteen == 3)
                {
                    aantal_3 =+ 1;
                } else if (dobbelsteen == 4)
                {
                    aantal_4 =+ 1;
                }else if (dobbelsteen == 5)
                {
                    aantal_5 =+ 1;
                }else if (dobbelsteen == 6)
                {
                    aantal_6 =+ 1;
                }

                if(i == 100)
                {
                    Console.WriteLine("aantal keer dat je 1 hebt gekregen: " + aantal_1);
                    Console.WriteLine("aantal keer dat je 2 hebt gekregen: " + aantal_2);
                    Console.WriteLine("aantal keer dat je 3 hebt gekregen: " + aantal_3);
                    Console.WriteLine("aantal keer dat je 4 hebt gekregen: " + aantal_4);
                    Console.WriteLine("aantal keer dat je 5 hebt gekregen: " + aantal_5);
                    Console.WriteLine("aantal keer dat je 6 hebt gekregen: " + aantal_6);
                }
            }

        }
    }
}
