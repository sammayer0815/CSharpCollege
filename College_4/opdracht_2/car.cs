public class Car
{
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public Car(String color)
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
        Console.WriteLine($"{Color} Car engine started");
    }

    public void StopEngine()
    {
        Console.WriteLine($"{Color} Car engine stopped");
    }

    public void Drive()
    {
        Console.WriteLine($"Riding a {Color} Car");
    }
}