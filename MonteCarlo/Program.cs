using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    public class Program
    {
        public static double Monte(int n)
        {
            int inside = 0;
            Random r = new Random();

            for (double i = 0; i < n; i++)
            {

                if (Math.Pow(r.NextDouble(), 2) + Math.Pow(r.NextDouble(), 2) <= 1)
                {
                    inside++;
                }

            }


            return 4.0 * inside / n;
        }

        public static void Main()
        {
            int num = 1;

            for (int n = 0; n < 4; n++)
            {
                num *= 10;

                Console.WriteLine("{0}:{1}", num.ToString("#,###").PadLeft(11, ' '), Monte(num));
            }
        }
    }
}
