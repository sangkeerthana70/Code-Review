using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV4Suerekha
{
    public class Board
    {
        private int widthOfBoard;
        private int heightOfBoard;

        public int WidthOfBoard { get => widthOfBoard; set => widthOfBoard = value; }
        public int HeightOfBoard { get => heightOfBoard; set => heightOfBoard = value; }

        public Board()
        {
            WidthOfBoard = 7;
            HeightOfBoard = 6;
            Board[,] board = new Board[7, 6];
        }

        
        public void DrawBlankSpacesInCell()
        {
            for(int row = 1; row < WidthOfBoard; row++)
            {
                Console.Write("|     ");
            }
            Console.WriteLine("|     |");
        }

        public void DrawBottomLinesOfCell()
        {
            for(int row = 1; row < WidthOfBoard; row++)
            {
                Console.Write("|_____");
            }
            Console.WriteLine("|_____|");
        }

        public void DrawGameBoard()
        {
            Console.Write(" -----------------------------------------");
            Console.WriteLine();
           
            for (int column = 0; column < HeightOfBoard; column++)
            {
                DrawBlankSpacesInCell();
                DrawBlankSpacesInCell();
                DrawBottomLinesOfCell();

            }
        }
 
    }

}

