// Logical operator:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Age: ");
        double Age = Convert.ToDouble(Console.ReadLine());


        // Both the Conditions must meet.
        if ( Age >= 18 &&  Age <= 24)
        {
            Console.WriteLine($" Your  Age is {Age} Years Old. \t \n You are Consider as Adult.");
        }

        // Only one condition must meet.
        else if (Age < 18 ||  Age > 24)
        {
            Console.WriteLine("Your Age is " + Age + " years old. \t \n You are not Considerd as Adult." );
        }

        else {
            Console.WriteLine(" Please Enter a valid Age!");
        }

        Console.ReadKey();
    }
}