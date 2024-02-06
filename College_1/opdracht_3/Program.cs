using System;

namespace opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Floors = 9;
            int LiftCount = 4;
            int[] Lifts = new int[LiftCount];
            int user = new Random().Next(0, Floors);
            int[] difference = new int[LiftCount];

            String above = "\u250F\u2513";
            String below = "\u2517\u251b";

            for (int i = 0; i < Lifts.Length; i++)
            {
                Lifts[i] = new Random().Next(0, Floors);
            }



            for (int i = 0; i < Lifts.Length; i++)
            {
                difference[i] = Math.Abs(user - Lifts[i]);
            }

            int minIndex = Array.IndexOf(difference, difference.Min());

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            for (int i = Floors; i > 0; i--)
            {
                for (int j = 0; j < LiftCount; j++)
                {
                    if (Lifts[j] == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(above);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(above);
                    }
                }
                Console.WriteLine();
            }


        }
    }
}