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

            Game game = new Game(6, 7, 'x', 'o');
            game.PrintGameState();

            game.ApplyMove(game.player1, 1);
            game.PrintGameState();
            


        }
    }
}
