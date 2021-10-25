using System;

namespace Code_Challenge_10_25
{
    class Program
    {
        public static void Main(String[] args)
        {
            try
            {
                string[] input = (Console.ReadLine()).Split('/');
                int numerator = Int32.Parse(input[0]);
                int denominator = Int32.Parse(input[1]);
                ReduceFraction(numerator, denominator);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void ReduceFraction(int numerator, int denominator)
        {
            int gcd;
            gcd = GreatestCommonDivisor(numerator, denominator);

            numerator = numerator / gcd;
            denominator = denominator / gcd;

            if (denominator == 1)
                Console.WriteLine(numerator);
            else
                Console.WriteLine($"{numerator}/{denominator}");
        }

        static int GreatestCommonDivisor(int a, int b)
        {
            if (b == 0)
                return a;
            return GreatestCommonDivisor(b, a % b);
        }
    }
}
