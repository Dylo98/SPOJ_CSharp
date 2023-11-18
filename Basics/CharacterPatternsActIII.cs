using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ.Basics
{
    internal class CharacterPatternsActIII
    {
        public void CPTTRN3()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                string rowsColumns = Console.ReadLine();
                string[] rowsColumnsArr = rowsColumns.Split(' ');

                int rows = int.Parse(rowsColumnsArr[0]);
                int columns = int.Parse(rowsColumnsArr[1]);

                for (int q = 0; q < rows * 3 + 1; q++)
                {
                    for (int j = 0; j < columns * 3 + 1; j++)
                    {
                        if (q == 0 || q == rows * 3 || i % 3 == 0)
                        {
                            Console.Write("*");
                        }
                        else if (j == 0 || j == columns * 3 || j % 3 == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        Console.ReadKey();
        }  
    }
}
