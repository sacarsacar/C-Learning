// Params Keyword:
internal class Program
{
    static void Main(string[] args)
    {

        // MUltiple inputs:
        double total = Bills(10, 20, 30, 30.5);

        Console.WriteLine($"Total price is : {total}");

        Console.ReadKey();
    }

    // params = can take multile values as a time(one dimensinal array)

    static double Bills(params double[] prices)
    {
        double total = 0;

        // using foreach loop for calculation
        foreach(double price in prices)
        {
            total += price;
        }

        return total;
    }
}