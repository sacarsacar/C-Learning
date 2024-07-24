// Arithmetic Operators:

using System.Numerics;
internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        int b = 5;
        int c = 5;
        int d = 10;


        // Incrementing Operations ( Addition)
        a = a + 1;   //Result : 1 + 1 = 2
        a += 1;      // Result : 1 + 1 = 2
        a++;         // Used in loop (Only incremented by 1)

        Console.WriteLine(a);


        // Decrementing Operations (Subtracting)
        b = b - 2;      // Result : 5 - 2 = 3
        b -= 2;         // Result : 5 - 2 = 3
        b--;           // Used in loop (Only decremented by 1)

        Console.WriteLine(b);


        // Multiplication:
        b = b * 3;         // Result : 5 * 3 = 15
        b *= 3;           // Result : 5 * 3 = 15

        Console.WriteLine(c);


        // Division:
        d = d / 2;         // Result : 10 / 2 = 2
        d /= 2;           // Result : 10 / 2 = 2

        Console.WriteLine(d);

        // Modulus Operator
        double remainder = d % 3;

        Console.WriteLine(remainder);

        Console.ReadKey();
    }
}