using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_paper_scissors
{
    class GameStarter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Rock Paper Scissors");
            GameBoard newGame = new GameBoard();
            Console.ReadLine();
        }
    }
}
