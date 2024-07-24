internal class Program
{
    static void Main(string[] args)
    {
        // Arrays in objects:

        car[] collection = { new car("BYD"), new car("Tesla"), new car("Kia EV6") };


        Console.WriteLine("-----Collections of Cars:----\t");

        foreach (car Car in collection)
        {
            Console.WriteLine("Name: " + Car.model);
        }

        Console.ReadKey();
    }
    class car
    {
        public string model;

        public car(string model)
        {
            this.model = model;
        }

    }
    
}