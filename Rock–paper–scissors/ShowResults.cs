using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Rock_paper_scissors
{
    public class ShowResults
    {
        int wins=0, loses=0;


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


    }
}
