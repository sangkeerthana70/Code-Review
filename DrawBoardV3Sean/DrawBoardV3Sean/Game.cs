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
            int es = emptyState;
            Console.WriteLine("es: " + es);
            for (int row = 0; row < moves.GetLength(0); row++)
            {
                for (int col = 0; col < moves.GetLength(1); col++)
                {

                    moves[row, col] = es;
                    Console.WriteLine("moves[{0},{1}] = {2}", row, col, moves[row, col]);

                }
            }
            //Console.ReadKey();

            return moves;
        }

        public void ApplyMove()
        {
            if (emptyState != 0 && player1 == 1) 
            {
                
            }
        }
    }   
}
