// interfaces: Defines a "Contract" that all the classes inheriting from should follow: An interface declares " what a class should have" 
internal class Program
{
    private static void Main(string[] args)
    {
        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        rabbit.Flee();
        hawk.Hunt();
        fish.Flee();
        fish.Hunt();

        Console.ReadKey();
    }

    // should use I while creating Interfaces:
    interface IPrey
    {
        void Flee();
    }

    // Predator interface 
    interface IPredator
    {
        void Hunt();  // Method Hunt
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The Rabbit runs away!");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The Hawk is Searching For Food!");
        }
    }

    //Method Using Both Interfaces:
    class Fish : IPrey,IPredator
    {

        public void Flee()
        {
            Console.WriteLine("The Fish is Swimming!");
        }
        public void Hunt()
        {
            Console.WriteLine("The Fish is Searching For Food!");
        }
    }

}