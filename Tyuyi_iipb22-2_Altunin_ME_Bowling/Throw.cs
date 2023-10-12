using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tyuyi_iipb22_2_Altunin_ME_Bowling
{
    public class Throw
    {
        private int score;
        public Throw(int score)
        { 
            this.score = score;
            if (score > 10) { throw new ArgumentOutOfRangeException(nameof(score), "Amount of points must be equal or less than 10"); }
        }
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                this.score = value;
            }
        }
    }
}
