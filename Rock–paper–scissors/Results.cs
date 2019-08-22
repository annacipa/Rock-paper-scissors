using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_paper_scissors
{
  public  class Results
    {
        //game round
        public int round;
        //what user played from the random generator
        public string what_user_played;
        //and who won finally
        public string who_won;
       

        //CONSTRUCTOR with data initialisation
        public Results(string what_he_playd_v, int round_r, string who_won_v)

        {
            this.what_user_played = what_he_playd_v;
            this.round = round_r;
            this.who_won = who_won_v;


        }

    }
   
}
