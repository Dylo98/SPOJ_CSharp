using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ.Basics
{
    internal class CharacterPatternsActII
    {
        public void CPTTRN2()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                string rowsColumns = Console.ReadLine();
                string[] rowsColumnsArr = rowsColumns.Split(' ');

                int rows = int.Parse(rowsColumnsArr[0]);
                int columns = int.Parse(rowsColumnsArr[1]);

                if (rows >= 3 && columns >= 3)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            if (j == 0 || k == 0 || j == rows - 1 || k == columns - 1)
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
                }
                else
                {
                    for (int j = 0; j < rows; j++)
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
