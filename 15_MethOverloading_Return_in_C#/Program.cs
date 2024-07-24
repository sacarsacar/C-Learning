// Return keyword and Method Overloading:
internal class Program
{
  static void Main(string[] args)
    {
        double a;
        double b;
        double result;

        Console.WriteLine("Multiplication:");

        Console.Write("Enter num 1: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter num 2: ");
        b = Convert.ToDouble(Console.ReadLine());

        result = Multiply(a, b);

        Console.WriteLine($"The multiplication of {a} * {b} = {result}");
       

        Console.ReadKey();
    }

    // use of return:
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Method Overloading: (Assigning new variable or value to existing method )

   // static double Multiply(double a, double b,double c)
   // {
     //   return a * b * c;
    //}
}