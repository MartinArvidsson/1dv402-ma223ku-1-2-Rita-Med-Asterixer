using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rita_med_asterixer
{
    class Program
    {
        static void Main(string[] args)
        {
            //int caseSwitch = 1;

            for (int i = 0; i < 25; i++)
            {
                Console.ResetColor();

                switch (i % 3) //Byter färg var tredje rad startar som nr. 1
                {
                    case 0: Console.ForegroundColor = ConsoleColor.Yellow; // skriver gul rad, får numret 2
              //          caseSwitch = 2;
                        break;

                    case 1: Console.ForegroundColor = ConsoleColor.Magenta; //Skriver rosa rad, får numret 3
                //        caseSwitch = 3;
                        break;

                    case 2: Console.ForegroundColor = ConsoleColor.Green; // Skriver grön rad, för nr 1
                  //      caseSwitch = 1;
                        break;

                }
                for (int j = 0; j < 39; j++) //så länge som j < 0 skriv ut *
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                if (i % 2 == 0)
                {
                    Console.Write(" "); //Varannan rad startas med ett mellanslag.
                }
            }
        }
    }
}
