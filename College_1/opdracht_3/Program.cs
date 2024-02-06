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

            DrawLiftLines(Floors, LiftCount, Lifts, above, below, user, minIndex);



        }

        static void DrawLiftLines(int Floors, int LiftCount, int[] Lifts, String above, String below, int user, int minIndex)
        {
            for (int i = 0; i < Floors; i++)
            {
                for (int j = 0; j < LiftCount; j++)
                {
                    if (Lifts[j] == i)
                    {
                        if(j == minIndex){
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                        }
                        else{
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(above);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(above);
                    }
                }
                if (i == user)
                {
                    Console.WriteLine($"  {above}");
                }
                else
                {
                    Console.WriteLine("");
                }

                for (int j = 0; j < LiftCount; j++)
                {
                    if (Lifts[j] == i)
                    {
                        if(j == minIndex){
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                        }
                        else{
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(below);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(below);
                    }
                }
                if (i == user)
                {
                    Console.WriteLine($"  {below}");
                }
                else
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}