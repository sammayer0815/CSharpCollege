public class Bike
{
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public Bike(String color)
    {
        Color = color;
        Vehicle();
    }

    public void Vehicle()
    {
        StartEngine();
        Drive();
        StopEngine();
    }

    public void StartEngine() 
    {
        Console.WriteLine($"{Color} Bike engine started");
    }

    public void StopEngine()
    {
        Console.WriteLine($"{Color} Bike engine stopped");
    }

    public void Drive()
    {
        Console.WriteLine($"Riding a {Color} bike");
    }
}