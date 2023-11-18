using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ.Basics
{
    internal class CharacterPatternsActI
    {
        public void CPTTRN1()
        {
            int input = int.Parse(Console.ReadLine());

            for (int k = 0; k < input; k++)
            {
                string rowsColumns = Console.ReadLine();
                string[] rowsColumnsArray = rowsColumns.Split(' ');
                int l = int.Parse(rowsColumnsArray[0]);

                int c = int.Parse(rowsColumnsArray[1]);


                for (int i = 1; i <= l; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 1; j <= c; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(".");
                            }
                        }
                    }
                    else
                    {
                        for (int j = 1; j <= c; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write(".");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }

    }
}
