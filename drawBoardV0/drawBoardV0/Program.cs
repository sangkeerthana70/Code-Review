using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawBoardV0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            DrawBoardV0(rows, columns);
            //DrawTicTacToe(rows, columns);
        }

        static void DrawBoardV0(int r, int c)
        {
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {   
                    //column 
                    if(j > 0 && j < c-1)
                    {
                        // rows
                        if (i > 0 && i < r - 1)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        Console.Write("*");
                    }
                   
                       
                    
                                     
                }
                Console.WriteLine();
            }
            //Console.WriteLine();
        }

        static void DrawTicTacToe(int rows, int columns)
        {
            int m = (2 * rows - 1);
            
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write(" |");
                    }
                    else
                    {
                        Console.Write("-+");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
