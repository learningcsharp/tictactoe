using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run until game is over or repeat until players want to quit?
            while (true)
            {
                // Show board options (should we do this outside the loop?)
                string board = TicTacToe.CreateDisplayBoard();
                Console.WriteLine(board);

                // Ask player 1 to play

                // Ask player 2 to play

                // Check if game is over
                // Do other logic
                Console.ReadKey();
            }
        }
    }
}
