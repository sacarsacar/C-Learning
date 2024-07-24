// Math Functions:
internal class Program
{
    private static void Main(string[] args)
    {
        double x = 5;
        double y = 3.52;

        double a = Math.Pow(x, 2);     //  5^2 = 25   [Power]
        Console.WriteLine("Power of 5^2 is : " + a);

        double b = Math.Cbrt(x);              // Cube root
        Console.WriteLine("\nCube Root of 5 is : " + b);

        double c = Math.Sqrt(x);               // Square root
        Console.WriteLine("\nThe Square Root of 5 is : " + c);

        double d = Math.Floor(y);                // floor (removes decimal values [smallest value])
        Console.WriteLine("\nThe floor of 3.52 is : " + d);

        double e = Math.Ceiling(y);              // celling (removes decimal values [largest value])
        Console.WriteLine("\nThe Celling of 3.52 is : " + e);

        double f = Math.Abs(y);                 // Absolute Value  (remove negative sign)
        Console.WriteLine("\nThe absolute value of 3.52 is : " + f);

        double g = Math.Min(x, y);               // Minimum Value 
        Console.WriteLine("\nThe Minimum Value between " + x + " and " + y + " is: " + g);

        double h = Math.Max(x, y);               // Maximum Value 
        Console.WriteLine("\nThe Maximum Value between " + x + " and " + y + " is: " + h);

        double i = Math.PI;                     // Pie Value
        Console.WriteLine("\nThe Value of Pie is : " + i);

        double j = Math.Round(y);              // Round  [Convert into nearest greatest value by removing decimal]
        Console.WriteLine("\nThe round of 3.52 is : " + j);

        Console.WriteLine("\n-------------------------------------------------------------------------\n");


        // Generating Random Numbers in C#:

        Random randomNumber = new Random();
        
        int num1 = randomNumber.Next(1,9);   // generating number between 1 to 9.
        Console.WriteLine("\nThe random Number between 1 and 9 is : " + num1);

        int num2 = randomNumber.Next(1, 9) + 100;   // generating number between 100 to 109 (same way for others).
        Console.WriteLine("\nThe random Number between 100 and 109 is : " + num2);

        double num = randomNumber.NextDouble();
        Console.WriteLine("\nThe random Number between 0 and 1 is : " + num);


        Console.ReadLine();
    }
}