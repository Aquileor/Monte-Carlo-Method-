using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("How many random points do you want the Monte Carlo method to run?");
            Console.Write("\nInput answer: ");

            int arrayvariable = Convert.ToInt32(Console.ReadLine());

            MonterCarlo[] coord = new MonterCarlo[arrayvariable];

            Random varaible = new Random();

            int counter = 0;

            for (int i = 0; i < arrayvariable; i++)
            {

                coord[i] = new MonterCarlo(varaible);

                if (coord[i].Monte() <= 1 )

                {
                    counter++;
                }

            }

            double avg = (counter / (double)coord.Length) * 4;
            double Diffrence = Math.Abs(avg - Math.PI );


            Console.WriteLine($"\nCounter equals {counter} and True Pi equals {Math.PI}");
            Console.WriteLine($"\nThe answer for your input is {avg}\n");
            Console.WriteLine($"The diffrence between True pi and your answer is {Diffrence}\n");


            Console.WriteLine("\nBelow are resuls for predetermined numbers.\n");


            int num = 1;
            for (int n = 0; n < 5; n++)
            {
                num *= 10;


                Console.WriteLine($"Amount of times random points were ploted {num} : Output answer {Monte(num)}\n");
            }
        }


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
  
            }
            return 4.0 * ((double)within / (double)n);
        }
    }

   
}


