using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
