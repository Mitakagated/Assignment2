using System;

namespace Section2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numberCompare();
            numFactorial();
        }

        private static void numberCompare()
        {
            try
            {
                Console.WriteLine("Write a number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Write a number again:");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine($"{num1} is bigger than {num2}");
                }
                else if (num1 < num2)
                {
                    Console.WriteLine($"{num2} is bigger than {num1}");
                }
                else
                {
                    Console.WriteLine("Both numbers are equal");
                }
            }
            catch (Exception)
            {
                throw new Exception("You have to type in a number without special characters.");
            }

            try
            {
                Console.WriteLine("Now type in total of 4 numbers to compare. Type the first number.");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the second number.");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the third number.");
                int num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the last number.");
                int num4 = int.Parse(Console.ReadLine());

                if ((num1 > num2) && (num1 > num3) && (num1 > num4))
                {
                    Console.WriteLine($"{num1} is the biggest number.");
                }
                else if ((num2 > num1) && (num2 > num3) && (num2 > num4))
                {
                    Console.WriteLine($"{num2} is the biggest number.");
                }
                else if ((num3 > num1) && (num3 > num2) && (num3 > num4))
                {
                    Console.WriteLine($"{num3} is the biggest number.");
                }
                else if ((num4 > num1) && (num4 > num2) && (num4 > num3))
                {
                    Console.WriteLine($"{num4} is the biggest number.");
                }
                else
                {
                    Console.WriteLine("There is no biggest number.");
                }
            }
            catch (Exception)
            {
                throw new Exception("You have to type in a number without special characters.");
            }

        }

        private static void numFactorial()
        {
            try
            {
                Console.WriteLine("Enter a number to find it's factorial");
                int number = int.Parse(Console.ReadLine());
                int fact = number;
                int i;
                for (i = number - 1; i >=1; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine($"The factorial is {fact}");
            }
            catch (Exception)
            {
                throw new Exception("You have to type in a number without special characters.");
            }
        }
    }
}
