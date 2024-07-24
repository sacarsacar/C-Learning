// methods:
internal class Program
{
    static void Main(string[] args)
    {
        int age = 0; 
        string name = "";

        HappyBirthday(age = 10, name ="Sakar Chaulagain");   // Calling method

        HappyBirthday(age = 18, name = "Zoombie");

        Console.ReadKey();
    }

    // method
    static void HappyBirthday (int age, string name){     

        Console.WriteLine("Happy Birthday To You !");
        Console.WriteLine("Happy Birthday Dear " + name);
        Console.WriteLine($"You Are Now {age} years old");
        Console.WriteLine("Happy Birthday To You !");
        Console.WriteLine();
        
    }
    
}