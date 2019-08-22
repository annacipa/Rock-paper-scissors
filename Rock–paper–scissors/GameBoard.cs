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
            newGame();

        }


        public void newGame()
        {
            Random random_value_of_opponent = new Random();


            for (int i = 0; i < Rounds; i++)
            {
                //random number for component
                var index = random_value_of_opponent.Next(0, 3);
                if (index == 2)
                {
                    //check the round
                    Console.WriteLine("Round is {0}", i+1);
                    //INSERT TO ARRAY RESULTS OF USER-WINNER
                    ResultArray.Add(new Results(Values[index], i + 1, "USER"));
                    var s = String.Format("Random value Chosen: {0} | Value he playd for Results Array{1} | Winner is  {2} |Index {3}", Values[index], ResultArray[i].what_user_played, ResultArray[i].who_won, i);
                    Console.Write(s);
                    Console.WriteLine(Environment.NewLine);


                }
                else if (index == 1)
                {
                    //check the round
                    Console.WriteLine("Round is {0}", i+1);
                    //INSERT TO ARRAY RESULTS OF PC-WINNER 
                    ResultArray.Add(new Results(Values[index], i + 1, "PC"));
                    var s = String.Format("Random value Chosen: {0} | Value he playd for Results Array{1} | Winner is  {2} |Index {3}", Values[index], ResultArray[i].what_user_played, ResultArray[i].who_won, i);
                    Console.Write(s);
                    Console.WriteLine(Environment.NewLine);

                }
                else
                {
                    //You output its a repeat and we need to redo the round


                    Console.Write("Repeat | Chose Rock !|  Round is {0}", i);
                    Console.WriteLine(Environment.NewLine);
                    //increase i to go previous round when redo round
                    i--;

                }

            }
            //cHECK IF IS PUT INTO  ARRAY
            Console.Write(ResultArray.Count());

        }


    }
}