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

           double X = 0.0, Y = 0.0;

           double within = 0.0;

            Random random = new Random();

            for (double i = 0; i < n; i++)
            {
                X = random.NextDouble();
                Y = random.NextDouble();


                if (Math.Pow(X, 2) + Math.Pow(Y, 2) <= 1)

                {
                    within++;
                }

            } return 4.0 * within / n;
        }

        public static void Main()
        {
            Console.WriteLine("\nThe answers for each test are displayed below.\n");

            int num = 1;
            for (int n = 0; n < 7; n++)
            {
                num *= 10;

                Console.WriteLine($"Amount of times the code was ran {num} : Output of the code { Monte(num)}\n");
            }
        }
    }
}


/*
1. Why do we multiply the value from step 5 above by 4? 

We multiply the value from step 5 by 4 becasue the circle is broken down into 4 sepreate quadrants and we are fouced on the first quadrant.

2. What do you observe in the output when running your program with parameters of increasing size?

I observe that as the paramter grow in size the output starts to get closer and more acuatre to true π.

3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?

No it does not because this code is truly random. Eveytime the code is ran the point will never start off the same. If this was the case
then this program would not truly be random.

4. Find a parameter that requires multiple seconds of run time. What is that parameter? How accurate is the estimated value of π.

The parameter that requires multiple seconds of run time is 10,000,000. The out put was 3.1409304 which is one of the closest so far to acutal 
Pi which is 3.14159.

5. Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.

The US Coast Guard utilizes Monte Carlo methods within its computer modeling software SAROPS in order to calculate the probable locations of
vessels during search and rescue operations. Each simulation can generate as many as ten thousand data points that are randomly distributed 
based upon provided variables.[83] Search patterns are then generated based upon extrapolations of these data in order to optimize the probability
of containment (POC) and the probability of detection (POD), which together will equal an overall probability of success (POS). Ultimately this
serves as a practical application of probability distribution in order to provide the swiftest and most expedient method of rescue, saving both
lives and resources
*/
