using System;

//using CenterSpace.NMath.Core;
/*
namespace CenterSpace.NMath.Core.Examples.CSharp
{
    /// <summary>
    /// A .NET example in C# showing how to calculate an approximation for Pi using a Monte
    /// Carlo method and the uniform random number generator class RandGenUniform.
    /// 
    /// Imagine a 2 x 2 square with corners at (1,1), (1,-1), (-1,-1) and (-1,1)
    /// and a unit circle, centered on the origin, inscribed within it. Generate 
    /// random points inside the square and let M be the number of points
    /// that fall within the unit circle and N be the total number of points
    /// generated. As the number N gets large, the quantity M/N should approximate the 
    /// ratio of the area of the circle to the square, which is pi/4. Hence, we can
    /// use the ratio 4*M/N to approximate Pi.
    /// </summary>
    class MonteCarloRNGExample
    {

        static void Main(string[] args)
        {
            // Construct a random number generator that generates random deviates
            // distributed uniformly over the interval [-1,1]
            var rng = new RandGenUniform(-1.0, 1.0);

            // We'll approximate pi to within 5 digits.
            double tolerance = 1e-5;

            double piApproximation = 0;
            int total = 0;
            int numInCircle = 0;
            double x, y; // Coordinates of the random point.

            // Generate random points until our approximation within
            // the desired tolerance.
            while (Math.Abs(Math.PI - piApproximation) > tolerance)
            {
                x = rng.Next();
                y = rng.Next();
                if (x * x + y * y <= 1.0) // Is the point in the circle?
                {
                    ++numInCircle;
                }
                ++total;
                piApproximation = 4.0 * ((double)numInCircle / (double)total);
            }

            Console.WriteLine();

            Console.WriteLine("Pi calculated to within {0} digits with {1} random points.",
              -Math.Log10(tolerance), total);
            Console.WriteLine("Approximated Pi = {0}", piApproximation);

            Console.WriteLine();
            Console.WriteLine("Press Enter Key");
            Console.Read();
        }
    }// class

}// namespace

//http://toreaurstad.blogspot.com/2015/07/calculating-pi-in-c-using-monte-carlo.html
//POSSIBLE LINK
//https://stackoverflow.com/questions/33186114/monte-carlo-pi-not-accurate




    */


/*
namespace MonteCarlo
{


static void Main(string[] args)
{
    double n;
    double count;
    double c = 0.0;
    double x = 0.0, y = 0.0;
    double pi;
    string input;

    Console.WriteLine("Please input a number of dots for Monte Carlo to calculate pi.");
    input = Console.ReadLine();
    n = double.Parse(input);

    Random rand = new Random();


    for (int i = 1; i < n; i++)
    {
        x = rand.Next(-1, 1);
        y = rand.Next(-1, 1);

        if (((x * x) + (y * y) <= 1))
            c++;
        pi = 4.0 * (c / i);
        Console.WriteLine("pi: {0,-10:0.00} Dots in square: {1,-15:0} Dots in circle: {2,-20:0}", pi, i, c);
    }
}
}
*/



















    /*
        public class Program
        {
        //Random random = new Random();
        public static double Monte(int n)
            {
             
                double X = 0.0, Y = 0.0;
                double inside = 0.0;
                Random random = new Random();

                for (double i = 0; i < n; i++)
                {
                X = random.Next(-1, 1);
                Y = random.Next(-1, 1);
                    if (Math.Pow(X, 2) + Math.Pow(Y, 2) <= 1)
                //random.NextDouble()
                {
                    inside++;
                    }

                }


                return 4.0 * inside / n;
            }

            public static void Main()
            {
            Console.WriteLine("The answers for each test are displayed below. . .\n");

            int num = 1;
            for (int n = 0; n < 6; n++)
                {
                    num *= 10;

                    Console.WriteLine($"Amount of times the code was ran {num} : Output of the code { Monte(num)}\n");
                //"{0}:{1}", num.ToString("#,###").PadLeft(11, ' '),
            }
        }
        }
        */
        
    }
//double n;
//double count;
//double c = 0.0;
//double x = 0.0, y = 0.0;
//double pi;
//string input;

//Console.WriteLine("Please input a number of dots for Monte Carlo to calculate pi.");
//        input = Console.ReadLine();
//        n = double.Parse(input);

//Random rand = new Random();


//        for (int i = 1; i<n; i++)
//        {
//            x = rand.Next(-1, 1);
//            y = rand.Next(-1, 1);

//            if (((x* x) + (y* y) <= 1))
//                c++;
//            pi = 4.0 * (c / i);
    

