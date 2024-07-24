internal class Program
{
    static void Main(string[] args)
    {
        // Creating thread:
        Thread mainThread = Thread.CurrentThread;

        CountUp();
        CountDown();

        Console.WriteLine("Thread is Completed!");

        Console.ReadKey();
    }

    // Button to Top(increasing):
    public static void CountUp()
    {
        for (int i=1; i<11; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

  //Top to Button(Decreasing):
    public static void CountDown()
    {
        for (int i = 10; i >=0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);    // time in milli second
        }
        Console.WriteLine();
    }

}