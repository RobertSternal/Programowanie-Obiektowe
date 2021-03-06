using System;

namespace Lab_7
{
    delegate double Operation(double a, double b);
    delegate double Power(double a, double b);
    class Program
    {

        static double Addition(double x, double y)
        {
            return x + y;
        }

        //zadeklaruj se Mula
        static double Mul(double x, double y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Operation add = Addition;
            double result = add.Invoke(3, 5);
            Console.WriteLine(result);
            //przypisz mull do add
            add = Mul;
            Console.WriteLine(add.Invoke(3, 5));

            Func<double, double, double> Operator = Addition;
            Func<double, double, double> Div = delegate (double x, double y)
            {
                return x / y;
            };

            Func<int> RandomInt = delegate ()
            {
                return new Random().Next(100);
            };
            Predicate<int> InRangeFrom0To100 = delegate (int value)
            {
                return value >= 0 && value <= 100;
            };
            Console.WriteLine(RandomInt.Invoke());
            Console.WriteLine(InRangeFrom0To100.Invoke(45));
            Func<int, int, int, bool> InRange = delegate (int value, int min, int max)
            {
                return value >= min && value <= max;
            };

            Action<string, int> Print = delegate (string s, int a)
            {
                Console.WriteLine(s + a);
            };
            Print.Invoke("abc", 5);

            Operation AddLambda = (a, b) => a + b;
            Func<double, double, double> DivLambda = (x, y) =>
            {
                if (y != 0)
                {
                    return x / y;
                }
                else
                {
                    throw new Exception("y is zero!");
                }
            };

            Predicate<string> ThreeCharacters = s => s.Length == 3;

        }
    }
}
