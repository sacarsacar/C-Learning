// TypeCasting:
internal class Program
{
    private static void Main(string[] args)
    {

        // Typecast --- converting data types

        Console.WriteLine("Converting double into int \n");

        // converting double into int:
        double a = 3.12;
        int b = Convert.ToInt32(a);

        Console.WriteLine(b);
        Console.WriteLine(a.GetType());  //  Displaying data type of a 
        Console.WriteLine(b.GetType());  //  Displaying data type of b

        Console.WriteLine("\n*****************************************\n");
        Console.WriteLine("Converting int into double\n");


        // Converting Int into Double:
        int c = 25;
        double d = Convert.ToDouble(c) + 0.5;

        Console.WriteLine(d);
        Console.WriteLine(c.GetType());  //  Displaying data type of c
        Console.WriteLine(d.GetType());  //  Displaying data type of c

        Console.WriteLine("\n*****************************************\n");
        Console.WriteLine("Converting int into string\n");


        // Converting Int into String:
        int e = 255;
        string f = Convert.ToString(e);

        Console.WriteLine(f);
        Console.WriteLine(e.GetType());  //  Displaying data type of e
        Console.WriteLine(f.GetType());  //  Displaying data type of f

        Console.WriteLine("\n*****************************************\n");
        Console.WriteLine("Converting string into char\n");


        // Converting String into Char:
        string g = "@";
        char h = Convert.ToChar(g);

        Console.WriteLine(h);
        Console.WriteLine(g.GetType());       // Displaying Data type of g
        Console.WriteLine(h.GetType());      // Displaying Data type of h

        Console.WriteLine("\n*****************************************\n");
        Console.WriteLine("Converting string into boolean\n");


        // Converting String into boolean:
        string i = "true";
        bool j = Convert.ToBoolean(i);

        Console.WriteLine(j);
        Console.WriteLine(i.GetType());       // Displaying Data type of i
        Console.WriteLine(j.GetType());      // Displaying Data type of j


        Console.ReadKey();
    }
}