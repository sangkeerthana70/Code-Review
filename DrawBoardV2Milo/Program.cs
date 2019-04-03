﻿using System;
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
            //DrawBoard(4, 8);
            Console.WriteLine("Enter height of board between 2 and 30: ");
            int height = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter width of board between 2 and 30");
            int width = Convert.ToInt32(Console.ReadLine());


            if (height < 2 || height > 30)
            {
                Console.WriteLine("Please enter a valid height");
            }
            if (width < 2 || width > 30)
            {
                Console.WriteLine("Please enter a valid width");
            }

            Game myGame = new Game(height, width);
            myGame.DrawBoard(height, width);
        }

       
            
           
               
          

    }
}
