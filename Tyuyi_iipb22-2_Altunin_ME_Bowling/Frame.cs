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
        public int[] ThrowScore
        {
            get
            {
                return tScore;
            }
            set
            {
                tScore[0] = Convert.ToInt32(value[0]);
                if (tScore[0] == 10)
                {
                    tScore[0] = value[0];
                    tScore[1] = 0;
                }
                else
                {
                    tScore[1] = Convert.ToInt32(value[2]);
                    this.tScore[1] = value[1];
                }
            }
        }
    }

}
