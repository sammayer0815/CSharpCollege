using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //answer();
            //recursion(1);
            recursionIf(1);
            //FibonacciRecursion(0, 1, 0);
        }

        static void FibonacciRecursion(int input_1, int input_2, int i)
        {
            i++;
            if (i > 10)
            {
                return;
            }

            int temp = input_1 + input_2;

            Console.WriteLine($"{i} is {temp}");

            input_1 = input_2;
            input_2 = temp;

            FibonacciRecursion(input_1, input_2, i);
        }

        static void recursion(int i)
        {
            switch (i)
            {
                case var _ when i == 99:
                    return;
                case var _ when i % 3 == 0 && i % 5 == 0:
                    Console.WriteLine("FizzBuzz");
                    recursion(i + 1);
                    break;
                case var _ when i % 3 == 0:
                    Console.WriteLine("Fizz");
                    recursion(i + 1);
                    break;
                case var _ when i % 5 == 0:
                    Console.WriteLine("Buzz");
                    recursion(i + 1);
                    break;
                default:
                    Console.WriteLine(i);
                    recursion(i + 1);
                    break;
            }

        }

        static void recursionIf(int i)
        {
            if (i >= 99)
            {
                return;
            }
            i++;

            bool printed = false;

            if (i % 3 == 0)
            {
                Console.Write("Fizz");
                printed = true;
            }

            if (i % 5 == 0)
            {
                Console.Write("Buzz");
                printed = true;
            }

            if (i % 7 == 0)
            {
                Console.Write("Bang");
                printed = true;
            }

            if(printed == true){
                Console.WriteLine();
            }
            else{
                Console.WriteLine(i);
            };

            recursionIf(i);
        }
        static void answer()
        {
            for (int i = 1; i <= 99; i++)
            {
                switch (i)
                {
                    case var _ when i % 3 == 0 && i % 5 == 0:
                        Console.WriteLine("FizzBuzz");
                        break;
                    case var _ when i % 3 == 0:
                        Console.WriteLine("Fizz");
                        break;
                    case var _ when i % 5 == 0:
                        Console.WriteLine("Buzz");
                        break;
                    case var _ when i % 7 == 0:
                        Console.WriteLine("Bang");
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
        }
    }
}
