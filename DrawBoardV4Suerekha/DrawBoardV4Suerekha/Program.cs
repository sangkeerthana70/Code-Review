using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV4Suerekha
{
    class Program
    {
        static void Main(string[] args)
        {
            Board newBoard = new Board();
            newBoard.DrawGameBoard();
            Game newGame = new Game(6, 7, 'x', 'o');
            
            newGame.ApplyMove('x', 1);
            
            foreach (var cell in newGame.GameState)
            {
                Console.Write(cell);
            }
        }
    }
}
