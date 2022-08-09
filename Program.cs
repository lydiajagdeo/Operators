using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int divide = a / b;

            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {divide} remainder {remainder}");

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

