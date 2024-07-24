// Arrays:
internal class Program
{
    private static void Main(string[] args)
    {
        string[] names = { "Sakar", "Anup", "Santosh", "Manjil", "Utshav", "Surendra" };

        // Displaying one at a time:
        Console.WriteLine(names[0]);
        Console.WriteLine("\n-------------------------------------------\n");
        // Changing item of array:
        names[5] = "Sujan";

        // Displaying all items using for loop:
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        Console.WriteLine("\n-------------------------------------------\n");


        // using for each loop:
        foreach(string name in names)
        {
            Console.WriteLine(name);     
        }




        Console.ReadKey();
    }
}