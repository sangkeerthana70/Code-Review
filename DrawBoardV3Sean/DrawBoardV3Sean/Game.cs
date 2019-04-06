using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV3Sean
{
    class Game
    {
        int emptyState;
        int player1;
        int player2;


        public Game(int s, int p1, int p2)
        {
            this.emptyState = 0;
            this.player1 = 1;
            this.player2 = 2;
        }



        public int[,] GameMoves(int height, int width)
        {
            int[,] moves = new int[height, width];
            
           
            for (int row = 0; row < moves.GetLength(0); row++)
            {
                for (int col = 0; col < moves.GetLength(1); col++)
                {

                    moves[row, col] = emptyState;
                    Console.WriteLine("moves[{0},{1}] = {2}", row, col, moves[row, col]);

                }
            }
            return moves;
        }


        public int[,]  ApplyMoves(int height, int width)
        {
            Console.WriteLine("in apply moves");
            int[,] oneMove = new int[height, width];
            
            
            for (int row = 0; row < oneMove.GetLength(0); row++)
            {
                for (int col = 0; col < oneMove.GetLength(1); col++)
                {
                    if(row == height -1 && col == width - 2)
                    {
                        oneMove[row, col] = player1;
                        Console.WriteLine("oneMove[{0},{1}] = {2}", row, col, oneMove[row, col]);
                    }
                    else
                    {
                        oneMove[row, col] = emptyState;
                        Console.WriteLine("oneMove[{0},{1}] = {2}", row, col, oneMove[row, col]);
                    }
     
                }
            }
            

            return oneMove;
        }


    }   
}
