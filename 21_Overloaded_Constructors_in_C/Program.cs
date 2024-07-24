// Constructor overloading:
internal class Program
{
    static void Main(string[] args)
    {
        // Create different instances using different constructors
        Fruits fruits1 = new Fruits("Red Apple", "Yellow Banana");
        Fruits fruits2 = new Fruits("Red Apple", "Yellow Banana", "Orange Orange");
        Fruits fruits3 = new Fruits("Red Apple", "Yellow Banana", "Orange Orange", "Green Mango");

        // Display the fruit information
        fruits1.DisplayFruits();
        fruits2.DisplayFruits();
        fruits3.DisplayFruits();


        Console.ReadKey();
    }

    class Fruits
    {
        String Apple;
        String Banana;
        String Orange;
        String Mango;

        public Fruits(String Apple, String Banana, String Orange, String Mango)
        {

            this.Apple = Apple;
            this.Banana = Banana;
            this.Orange = Orange;
            this.Mango = Mango;
        }

       
        //  Overloading:
        public Fruits(String Apple, String Banana, String Orange)
        {

            this.Apple = Apple;
            this.Banana = Banana;
            this.Orange = Orange;
        }

        //  Overloading:
        public Fruits(String Apple, String Banana)
        {

            this.Apple = Apple;
            this.Banana = Banana;
        }


        // Method to display fruit information
        public void DisplayFruits()
        {
            Console.WriteLine($"Apple: {Apple}, Banana: {Banana}, Orange: {Orange}, Mango: {Mango}");
        }

    }
}