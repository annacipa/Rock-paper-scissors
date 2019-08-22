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
            Enter:  var line = Console.ReadLine();
            //convert inputed value from string to int
            int answer = Convert.ToInt32(line);
            //check the value entered
            if (answer == 1)
                {
                //if 1 then we go to the playinh round

                    GameBoard newGame = new GameBoard();
                    Console.WriteLine("Thank you for Playing! Want to Play again?Type 1 to play, Type 2 or any key to exit");
                //check if user wants to play again 
                goto Enter;
                }
             else
                {
                    Console.WriteLine("Game Exited");

                }

                Console.WriteLine(Environment.NewLine);

            } 

        }
    }

