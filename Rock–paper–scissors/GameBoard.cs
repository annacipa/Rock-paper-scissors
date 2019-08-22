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
        private const int Rounds = 100;
        private const String RockOfPC = "Rock";
        private string[] Values = {"Rock","Scissors","Paper"};

        public int ties = 0;

        public List<Results> ResultArray = new List<Results>();


        public GameBoard()
        {
            NewGame();
          
            ShowResults results = new ShowResults(ResultArray,ties);

            //Ask user if they want detailed info per round of results
            Console.WriteLine("Do you want detailed info of the outcomes per round? Press 1! Else press anything to exit! ");
            var line = Console.ReadLine();
            int answer = Convert.ToInt32(line);
            //check the value entered
            if (answer == 1)
            {
                ShowResults results2 = new ShowResults();
                results2.ShowResultsbyRound(ResultArray);
                Console.WriteLine(Environment.NewLine);

            }
            

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
                    this.ties++;
                    i--;

                }

            }
           
        }


    }
}