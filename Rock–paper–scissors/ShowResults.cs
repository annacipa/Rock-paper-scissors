using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Rock_paper_scissors
{
    public class ShowResults
    {
        int wins=0, loses=0;

        public ShowResults()
        {

        }
        public ShowResults(List<Results> resultsToShow, int ties)
        {

           
            for (int i = 0; i < resultsToShow.Count(); i++)
            {

                if (!String.Equals("PC",resultsToShow[i].who_won))
                    loses++;
                else
                    wins++;

            }
            Console.Write("In this game there were Wins: {0} & Loses :{1} & Ties: {2} ", wins , loses, ties);
            Console.WriteLine(Environment.NewLine);


        }

        public void ShowResultsbyRound(List<Results> resultsToShow)
        {
            for (int i = 0; i < resultsToShow.Count(); i++)
            {
                var s = String.Format(" Random value Chosen: {0} | Round : {1} | Winner is  {2} ", resultsToShow[i].what_user_played, resultsToShow[i].round, resultsToShow[i].who_won);
                Console.WriteLine(s);
            }
        }


    }
}
