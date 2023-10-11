using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuyi_iipb22_2_Altunin_ME_Bowling
{
    internal class Program
    {
/*        internal int DoAThrow(int input) 
        {

        }
*/
        static void Main(string[] args)
        {
            int[] frame = new int[2];
            int input = 0;
            for (int i = 0; i < 2; i++) 
            {
                Console.WriteLine("Введите очки за бросок");
                input = Convert.ToInt32(Console.ReadLine());
                Throw attempt = new Throw(input);
                frame[i] = Convert.ToInt32(attempt);

            }
            Frame curframe = new Frame(frame);

        }
    }
}
