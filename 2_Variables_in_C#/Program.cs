// Variables in c#
internal class Program
{
    private static void Main(string[] args)
    {
        int x; // declaration
        x = 12; // initialization 

        int y = 21;  // declaration + initialization at once

        int z = x + y;    // int addition

        double height = 10.53;  // double 

        bool alive = true;   // boolean value

        char symbol = '@';     //char

        String Name = "Sakar Chaulagain";   // String Declaration

        String UserName = symbol + Name;    // Combining different data types 

        // printing results
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(alive);

        //printing with message
        Console.WriteLine("Hello " + Name + ", Good Morning😉");
        Console.WriteLine("The sum of " + x + " and " + y + " is:" + z);
        Console.WriteLine("Your Height is : " + height + "ft.");
        Console.WriteLine("The char is " + symbol);

        Console.Write("\nYour UserName is: " + symbol + Name + ".");



    Console.ReadKey();

    }
}