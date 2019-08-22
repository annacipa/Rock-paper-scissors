using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rock_paper_scissors
{
    public class GameBoard
    {
        private
        const int Rounds = 100;
        private
        const String RockOfPC = "Rock";
        private string[] Values = {"Rock","Scissors","Paper"};

        public List<Results> ResultArray = new List<Results>();


        public GameBoard()
        {
            NewGame();
            ShowResults results = new ShowResults(ResultArray);

        }


        public void NewGame()
        {
            Random random_value_of_opponent = new Random();


            for (int i = 0; i < Rounds; i++)
            {
                //random number for component
                var index = random_value_of_opponent.Next(0, 3);
                if (index == 2)
                {
                    //Insert value of round for user as winner
                    ResultArray.Add(new Results(Values[index], i + 1, "USER"));
                }
                else if (index == 1)
                {
                    //Insert value of round for pc as winner
                    ResultArray.Add(new Results(Values[index], i + 1, "PC"));

                }                
                else
                {
                    //repeat game with no result saved
                    i--;

                }

            }
           
        }


    }
}