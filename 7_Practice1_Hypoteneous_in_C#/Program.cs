// Hypotenuse Area:
internal class Program
{
    private static void Main(string[] args)
    {

        // Taking User Input & Converting it into Double
        Console.Write("Enter the Value of Side A: ");
        double a = Convert.ToDouble (Console.ReadLine());  

        Console.Write("Enter the Value of Side B: ");
        double b = Convert.ToDouble(Console.ReadLine());


        // using Math.Sqrt() to get square root of entered number
        double c = Math.Sqrt((a * a) + (b * b));

        Console.WriteLine("\nThe Area of Entered Hypotenuse is : " + c);

        Console.ReadKey();
    }
}