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
            //Welcoming message
            Console.WriteLine("Welcome to the game of Rock Paper Scissors");
            //Instructions for interactivity
            Console.WriteLine("Type 1 to play,type anyting else  to exit");
            //a point to enter to go in loop if player wants to play again
            string line = Console.ReadLine();

            do {
               

                //check the value entered
                if (string.Equals(line, "1"))
                {
                    //if 1 then we go to the playing round

                    GameBoard newGame = new GameBoard();
                    Console.WriteLine("Thank you for Playing! Want to Play again? Type 1 to play, type 2 or any key to exit");
                    line = Console.ReadLine();
                    //reenter loop
                     continue;
                }
                else
                {
                    Console.WriteLine("Game Exited");
                    break;

                }
            } while (line!=null );

                Console.WriteLine(Environment.NewLine);

            } 

        }
    }

