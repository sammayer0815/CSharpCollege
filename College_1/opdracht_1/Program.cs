using System;

namespace opdracht_1
{
    class Program
    {
        public static int globalNumber;
        static void Main(string[] args)
        {
            Console.WriteLine(divideNumbers(10, 0));

            globalNumber = 5;

            Console.WriteLine(multiplyGlobalNumber(3));

            Console.WriteLine(modifyArray());
        }

        public static string divideNumbers(float a, float b)
        {
            if (b == 0.0)
            {
                return ("Undefined");
            }
            else if (Math.Abs(b) < 1)
            {
                return ("Small Divider: " + (a / b));
            }
            else
            {
                return ("Result: " + (a / b));
            }
        }

        public static String multiplyGlobalNumber(int value)
        {
            int result = value * globalNumber;
            return ($"Global product: {result}");
        }

        public static String modifyArray()
        {
            int[] arr = [1, 2, 3];

            return ($"Modified Array:");
        }

        public static void loopError()
        {
            for(int i = 5;i != 0;){

            }
        }

    }
}