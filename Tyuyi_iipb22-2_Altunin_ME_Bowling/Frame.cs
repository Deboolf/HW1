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
        public int[] tScore;
        public Frame(int[] tScore)
        {
            this.tScore = tScore;
        }
        public int[] TrowScore
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
