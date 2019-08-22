using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_paper_scissors
{
  public  class GameBoard
    {
        private const int Rounds = 100;
        private const String RockOfPC = "Rock";
        private string[] Values = { "Rock", "Scissors", "Paper" };



        public GameBoard()
        {
            newGame();
        }


        public void newGame()
        {
            Random random_value_of_opponent = new Random();


            for (int i = 0; i < 5; i++)
            {
                //random number for component
                var index = random_value_of_opponent.Next(0, 3);
                if (index == 2)
                {
                    Console.Write("Wins user"+ Environment.NewLine);
                   
                }
                else if (index == 1)
                {
                    Console.Write("Wins pc"+ Environment.NewLine);
                }
                else
                {
                    Console.Write("Repeat"+ Environment.NewLine);
                }

                }

        }


        }
}
