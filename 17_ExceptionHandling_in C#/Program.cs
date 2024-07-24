//Exception Handling:
internal class Program
{
    static void Main(string[] args)
    {
        double a;
        double b;
        double result;

        // Write code which may cause error in try block:
        try
        {
            Console.Write("Enter num 1:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num 2:");
            b = Convert.ToInt32(Console.ReadLine());

            result = a / b;
            Console.WriteLine("Result: " + result);
        }

        // Display error message:
        catch(FormatException) {
            Console.WriteLine("PLEASE Enter Number only!");
        }

        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't Divide by Zero!");
        }

        // Always execute
        finally
        {
            Console.WriteLine("\t\t\t\t\nHAVE A GOOD DAY!");
        }
       
        Console.ReadKey();
    }
}