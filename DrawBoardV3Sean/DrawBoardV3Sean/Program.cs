﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV3Sean
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("select amount of rows");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("select amount of columns");
            int columns = Convert.ToInt32(Console.ReadLine());
            Board newBoard = new Board();
            

            Game game = new Game(6, 7, 'x', 'o');
           
            newBoard.BuildBoard(rows, columns);

            game.ApplyMove(game.player1, 1);
            game.PrintGameState();

 


        }
    }
}
