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
            int caseSwitch = 1;

            for (int i = 0; i < 25; i++)
            {
                Console.ResetColor();

                switch (caseSwitch)
                {
                    case 1: Console.ForegroundColor = ConsoleColor.Yellow;
                        caseSwitch = 2;
                        break;

                    case 2: Console.ForegroundColor = ConsoleColor.Magenta;
                        caseSwitch = 3;
                        break;

                    case 3: Console.ForegroundColor = ConsoleColor.Green;
                        caseSwitch = 1;
                        break;

                }
                for (int j = 0; j < 39; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
