using System;
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

            Board board = new Board();
            Game game = new Game(0, 1, 2);
            
            board.BuildBoard(rows, columns, game.GameMoves(rows, columns));
            //game.ApplyMoves(rows, columns);
            board.BuildBoard(rows, columns, game.ApplyMoves(rows, columns));
        }
    }
}
