using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DrawBoardV2Milo
{
    class Board
    {
        // Great functionality and code simplified
        public static void Main(string[] args)
        {
            DrawBoard(4, 8);
        }

        private static void drawTop()
        {
            Write(" __ ");
        }

        private static void drawWalls()
        {
            Write("|  |");
        }

        private static void drawBottom()
        {
            Write("+--+");
        }

        /* I really like the way you have simplified the entire draw board challenge. 
         * But one of the ways you could change the code is objectifying the whole code to separate the static DrawBoard
         * into a separate class and include your drawTop, drawWalls, drawBottom methods inside the class.
         * This will help in code reusability and implementing  OOPS concepts for further usage.*/
         
        private static void DrawBoard(int height, int width)
        {
            for (int rowCounter = 0; rowCounter < height; rowCounter++)
            {
                for (int columnCounter = 0; columnCounter < width; columnCounter++)
                {
                    drawTop();
                }
                Console.WriteLine();
                for (int wallCounter = 0; wallCounter < width; wallCounter++)
                {
                    drawWalls();
                }
                Console.WriteLine();
                // the draw bottom can be changed to draw " __ " which will look like the second draw board image of Cliff's.
                for (int bottomCounter = 0; bottomCounter < width; bottomCounter++)
                {
                    drawBottom();
                }
                Console.WriteLine();
            }
        }
    }
}
