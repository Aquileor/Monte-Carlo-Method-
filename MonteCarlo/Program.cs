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
            double inwith = 0.0;
            Random varaible = new Random();

            Console.WriteLine("How many random points do you want the Monte Carlo method to run?");
            Console.Write("\nInput answer: ");

            int variable = Convert.ToInt32(Console.ReadLine());

            MonterCarlo[] PossiblePoint = new MonterCarlo[variable];

            for (int i = 0; i < variable; i++)
            {

                PossiblePoint[i] = new MonterCarlo(varaible);

                if ( PossiblePoint[i].Monte(PossiblePoint[i]) <= 1 )

                {
                    inwith++;
                }

            }

            double Answer = 4.0 * ((double)inwith / (double)variable);
            double Diffrence = Math.Abs(Answer - Math.PI );


            Console.WriteLine("\nThe answers for different tests are displayed below.\n");
            Console.WriteLine($"Remember that true Pi equlas {Math.PI}");
            Console.WriteLine($"\nThe answer for your input is {Answer}\n");
            Console.WriteLine($"The diffrence between True pi and your answer is {Diffrence}\n");


            Console.WriteLine("\nBelow are resuls for predetermined numbers.\n");


            int num = 1;
            for (int n = 0; n < 6; n++)
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
public struct MonterCarlo
{
    public double X, Y;

    public MonterCarlo(double X, double Y)
    {
        this.X = X;
        this.Y = Y;
    }
    public MonterCarlo(Random randomValue)
    {
        X = randomValue.NextDouble();
        Y = randomValue.NextDouble();
    }

    public double Monte(MonterCarlo equation)
    {
        return Math.Sqrt(Math.Pow(equation.X, 2) + Math.Pow(equation.Y, 2));
    }
}

