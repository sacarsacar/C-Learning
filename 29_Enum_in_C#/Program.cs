// enums 
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Days.Sunday + " is a Day.");  // printing String
        Console.WriteLine((int)Days.Monday + " = Monday");   // Printing Int Along with string

        Console.ReadKey();
    }
}

// Use enums when you know values you have won't change.
enum Days
{
    Sunday = 1, Monday = 2, Tuesday = 3, Wednesday = 4,Thursday = 5, Friday = 6, Saturday = 7
}
