using System;

namespace opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int sizeX = 60;
            int sizeY = 40;

            // Ensure the size does not exceed the maximum.
            sizeX = Math.Min(sizeX, Console.LargestWindowWidth);
            sizeY = Math.Min(sizeY, Console.LargestWindowHeight);

            // Set the buffer size before the window size.

            Console.SetWindowSize(sizeX, sizeY);
            // Set the buffer size to the same as the window size. And fixes error SetBufferSize is only supported on Windows.
            if(System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
{
                Console.SetBufferSize(sizeX + 2, sizeY + 2);
            }

            drawBox(sizeX, sizeY);

            Console.SetCursorPosition(0, sizeY);

            Console.ReadLine();

        }

        static void drawBox(int sizeX, int sizeY)
        {

            // Writes top line of the box
            string top = "\u250F";

            for (int i = 0; i < (sizeX - 2); i++)
            {
                top += "-";
            }

            top += "\u2513";

            Console.WriteLine(top);

            // Writes the sides of the box
            string sides = "|";

            for (int i = 0; i < (sizeX - 2); i++)
            {
                sides += " ";
            }

            sides += "|";

            for (int i = 0; i < (sizeY - 2); i++)
            {
                Console.WriteLine(sides);
            }

            // Writes bottom line of the box
            string bottom = "\u2517";
            for (int i = 0; i < (sizeX - 2); i++)
            {
                bottom += "-";
            }

            bottom += "\u251B";

            Console.WriteLine(bottom);
        }
    }
}