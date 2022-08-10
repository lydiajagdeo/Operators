using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;

            Console.WriteLine($"Add: {num1+num2}");
            Console.WriteLine($"Subtract: {num1 - num2}");
            Console.WriteLine($"Multiply: {num1 * num2}");

            int a = 17;
            int b = 4;

            int quotient = a / b;

            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");

            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);

            Console.WriteLine(AreaofCircle(radius));



            static double AreaofCircle (double radius)
            {
                var area = Math.PI * Math.Pow(radius, 2);
                return area;

            }

            

        }

        
    }


}

