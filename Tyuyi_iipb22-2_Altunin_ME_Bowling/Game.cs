using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuyi_iipb22_2_Altunin_ME_Bowling
{
    public class Game
    {
        public Game() 
        {
            int[] input = new int[2];
            for (int i = 0; i == 10; i++) 
            {
                Frame fr = new Frame(input);
            }
        }
        public Game(string name) { }
        public Game(string name, int id)
        {

        }
    }
}
