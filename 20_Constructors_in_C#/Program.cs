// Constructures:
internal class Program

{
    static void Main(string[] args)
    {
        Car car1 = new Car("Ford", "Mustang",2001,"red");

        car1.Drive();

        Console.ReadKey();
    }
    
    class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine($"You are driving the {make} {model} ");
        }
    }
}