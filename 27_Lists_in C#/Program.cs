// Lists: Can be increased and deceased dynamically!
internal class Program
{
    private static void Main(string[] args)
    {
        // CREATING LIST:
        List<String> fruits = new List<String>();


        // Adding Fruits in the list:
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Mango");

        // Displaying fruits:
        foreach (String fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        fruits.Remove("Apple");  // Remove apple from list
        fruits.Insert(0, "Papaya");  // insert papaya at index 0
        fruits.Sort();  // Alphabetical Order
        fruits.Reverse(); // Reverse Order
        //fruits.Clear();  // Clear all items in the list

        Console.WriteLine(fruits.Count);  // Display no of items in the list
        Console.WriteLine(fruits.Contains("Guava"));  // Given item is in the list or Not.



        // Converting List into Array:
        String[] fruits2 = fruits.ToArray();

        Console.WriteLine("\n*************After Chanages******************\n");
        // Displaying fruits After Changes:
        foreach (String fruit in fruits)
        { 
            Console.WriteLine(fruit);
        }



        Console.ReadKey();
    }
}


// There are Many more methods like above if you want to know more please do some research🤣