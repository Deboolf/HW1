using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuyi_iipb22_2_Altunin_ME_Bowling
{

    public class Frame
    {
        Throw attempt = new Throw(0);
        public int[] tScore = new int[2];
        public Frame(int[] tScore)
        {
            this.tScore = tScore;
        }
        public int[] Score(Throw att1, Throw att2) 
        {
            tScore[0] = Convert.ToInt32(att1);
            if (tScore[0] == 10) 
            {
                return tScore;
            }
            else
            {
                tScore[1] = Convert.ToInt32(att2);
                return tScore;
            }   
        }
        public int[] ThrowScore
        {
            get
            {
                return tScore;
            }
            set
            {
                this.tScore = value ;
            }
        }
    }

}
