﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV3Sean
{
    class Board
    {
        static String[] parts = { "|", " ", "+", "-" };
        String wall = parts[0];
        String space = parts[1];
        String plus = parts[2];
        String dash = parts[3];

        public void BuildBoard(int height, int width, int[,] moves)
        {
            for (var vert = 0; vert <= height * 2; vert++)
            {
                for (var horz = 0; horz <= width; horz++)
                {
                    if (vert % 2 == 0)
                    {
                        Console.Write(plus + dash);
                        if (horz == width - 1)
                        {
                            Console.Write(plus + space);
                            break;
                        }
                    }
                    else
                    {
                        if (horz == width)
                        {
                            Console.Write(wall + space);
                        }
                        else
                        {
                            Console.Write(wall + moves[vert / 2, horz / 2]);
                        }

                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    /*
    class game
    {
        public char[,] GameMoves(int height, int width)
        {
            char[,] moves = new char[height, width];
            return moves;
        }
    }
    */
}

