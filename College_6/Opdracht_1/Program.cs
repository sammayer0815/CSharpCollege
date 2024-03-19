
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Voer de noemer in: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Voer de deler in: ");
            int b = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Input was not formatted correctly. Only input numbers");
            Main();
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cant divide by 0, so don't");
            Main();
        }
    }
}



