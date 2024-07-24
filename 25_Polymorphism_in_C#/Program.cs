// polymorphism: Having many forms !  (Here: Vehicle is having many forms.)
using System.ComponentModel.DataAnnotations;

internal class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Bike bike = new Bike();

        // Declearing array
        Vehicle[] vehicles = { car, bicycle, bike };

        // Using foreach loop to display:
        foreach(Vehicle vehicle in vehicles)
        {
            vehicle.Start();
        }

        Console.ReadKey();
    }
}

// Creating Vehicle Class
class Vehicle
{
    public virtual void Start() { }
}

class Car : Vehicle
{
    // Method Overriding
    public override void Start() {
        Console.WriteLine("The Car is Racing!");
    }
}

class Bicycle : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("The Bicycle is Racing!");
    }
}

class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("The Bike is Racing!");
    }
}


