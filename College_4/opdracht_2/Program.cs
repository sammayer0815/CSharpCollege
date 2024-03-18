using System;

namespace FlorisVx
{
    class Program
    {
        static void Main(string[] args)
        {
            new Bike("Red");
            new Bike("Yellow");
            new Bike("Blue");

            new Car("Red");
            new Car("Yellow");
            new Car("Blue");

            RedTruck redTruck = new RedTruck();
            redTruck.StartEngine();
            redTruck.Drive();
            redTruck.LoadCargo();
            redTruck.StopEngine();

            YellowTruck yellowTruck = new YellowTruck();
            yellowTruck.StartEngine();
            yellowTruck.Drive();
            yellowTruck.LoadCargo();
            yellowTruck.StopEngine();

            BlueTruck blueTruck = new BlueTruck();
            blueTruck.StartEngine();
            blueTruck.Drive();
            blueTruck.LoadCargo();
            blueTruck.StopEngine();

            RedPlane redPlane = new RedPlane();
            redPlane.StartEngine();
            redPlane.Drive();
            redPlane.Fly();
            redPlane.StopEngine();

            YellowPlane yellowPlane = new YellowPlane();
            yellowPlane.StartEngine();
            yellowPlane.Drive();
            yellowPlane.Fly();
            yellowPlane.StopEngine();

            BluePlane bluePlane = new BluePlane();
            bluePlane.StartEngine();
            bluePlane.Drive();
            bluePlane.Fly();
            bluePlane.StopEngine();

            RedCargoPlane redCargoPlane = new RedCargoPlane();
            redCargoPlane.StartEngine();
            redCargoPlane.Drive();
            redCargoPlane.Fly();
            redCargoPlane.LoadCargo();
            redCargoPlane.StopEngine();

            YellowCargoPlane yellowCargoPlane = new YellowCargoPlane();
            yellowCargoPlane.StartEngine();
            yellowCargoPlane.Drive();
            yellowCargoPlane.Fly();
            yellowCargoPlane.LoadCargo();
            yellowCargoPlane.StopEngine();

            BlueCargoPlane blueCargoPlane = new BlueCargoPlane();
            blueCargoPlane.StartEngine();
            blueCargoPlane.Drive();
            blueCargoPlane.Fly();
            blueCargoPlane.LoadCargo();
            blueCargoPlane.StopEngine();
        }
    }

    public class RedCar
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public RedCar()
        {
            Color = "Red";
        }

        public void StartEngine()
        {
            Console.WriteLine("Red Car engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Red Car engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a red car");
        }
    }

    public class BlueBike
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public BlueBike()
        {
            Color = "Blue";
        }

        public void StartEngine()
        {
            Console.WriteLine("Blue Bike engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Blue Bike engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Riding a blue bike");
        }
    }

    public class RedTruck
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public RedTruck()
        {
            Color = "Red";
        }

        public void StartEngine()
        {
            Console.WriteLine("Red Truck engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Red Truck engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a red truck");
        }

        public void LoadCargo()
        {
            Console.WriteLine("Loading cargo in red truck");
        }
    }

    public class YellowCar
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public YellowCar()
        {
            Color = "Yellow";
        }

        public void StartEngine()
        {
            Console.WriteLine("Yellow Car engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Yellow Car engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a yellow car");
        }
    }

    public class YellowTruck
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public YellowTruck()
        {
            Color = "Yellow";
        }

        public void StartEngine()
        {
            Console.WriteLine("Yellow Truck engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Yellow Truck engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a yellow truck");
        }

        public void LoadCargo()
        {
            Console.WriteLine("Loading cargo in yellow truck");
        }
    }

public class RedPlane
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public RedPlane()
        {
            Color = "Red";
        }

        public void StartEngine()
        {
            Console.WriteLine("Red Plane engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Red Plane engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a red plane on the ground");
        }

        public void Fly()
        {
            Console.WriteLine("Flying a red plane");
        }
    }

    public class BluePlane
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public BluePlane()
        {
            Color = "Blue";
        }

        public void StartEngine()
        {
            Console.WriteLine("Blue Plane engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Blue Plane engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a blue plane on the ground");
        }

        public void Fly()
        {
            Console.WriteLine("Flying a blue plane");
        }
    }

    public class YellowPlane
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public YellowPlane()
        {
            Color = "Yellow";
        }

        public void StartEngine()
        {
            Console.WriteLine("Yellow Plane engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Yellow Plane engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a yellow plane on the ground");
        }

        public void Fly()
        {
            Console.WriteLine("Flying a yellow plane");
        }
    }

    public class BlueCar
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public BlueCar()
        {
            Color = "Blue";
        }

        public void StartEngine()
        {
            Console.WriteLine("Blue Car engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Blue Car engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a blue car");
        }
    }

    public class RedCargoPlane
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public RedCargoPlane()
        {
            Color = "Red";
        }

        public void StartEngine()
        {
            Console.WriteLine("Red Cargo Plane engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Red Cargo Plane engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a red cargo plane on the ground");
        }

        public void Fly()
        {
            Console.WriteLine("Flying a red cargo plane");
        }

        public void LoadCargo()
        {
            Console.WriteLine("Loading cargo in red cargo plane");
        }
    }

    public class YellowCargoPlane
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public YellowCargoPlane()
        {
            Color = "Yellow";
        }

        public void StartEngine()
        {
            Console.WriteLine("Yellow Cargo Plane engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Yellow Cargo Plane engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a yellow cargo plane on the ground");
        }

        public void Fly()
        {
            Console.WriteLine("Flying a yellow cargo plane");
        }

        public void LoadCargo()
        {
            Console.WriteLine("Loading cargo in yellow cargo plane");
        }
    }

    public class BlueCargoPlane
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public BlueCargoPlane()
        {
            Color = "Blue";
        }

        public void StartEngine()
        {
            Console.WriteLine("Blue Cargo Plane engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Blue Cargo Plane engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a blue cargo plane on the ground");
        }

        public void Fly()
        {
            Console.WriteLine("Flying a blue cargo plane");
        }

        public void LoadCargo()
        {
            Console.WriteLine("Loading cargo in blue cargo plane");
        }
    }

    public class BlueTruck
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public BlueTruck()
        {
            Color = "Blue";
        }

        public void StartEngine()
        {
            Console.WriteLine("Blue Truck engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Blue Truck engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a blue truck");
        }

        public void LoadCargo()
        {
            Console.WriteLine("Loading cargo in blue truck");
        }
    }
}