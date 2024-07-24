
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nUse of If else Statement:\n");

        // Use of if else :
        Console.WriteLine("Enter Your Age:");
        int Age = Convert.ToInt32(Console.ReadLine());

        if (Age < 18)
        {
            Console.WriteLine($"\nYou are {Age} Years Old. You are not eligiable for this!");
        }
        else if (Age >= 90)
        {
            Console.WriteLine($"\nYou are {Age} Years Old. You are too Old!");
        }
        else
        {
            Console.WriteLine($"\nYou are {Age} Years Old. You Can Proceed Further");
        }



        // Use of switch case:

        Console.WriteLine("\n\t\tBasic Calculator:");


        Console.Write("\nEnter  First Number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please Enter the following sign to Perform Calculations: \n Addtion = + \n Subtraction = - \n Multipliaction = * \n Division = / \n");
        string sign = Convert.ToString(Console.ReadLine());

        double Result;

        switch (sign)
        {
            case "+":
                Result = num1 + num2;
                Console.WriteLine($"\nThe addition of {num1} and {num2} is : {Result}");
                break;

            case "-":
                Result = num1 - num2;
                Console.WriteLine($"\nThe subtraction of {num1} and {num2} is : {Result}");
                break;

            case "*":
                Result = num1 * num2;
                Console.WriteLine($"\nThe multiplication of {num1} and {num2} is : {Result}");
                break;

            case "/":
                if (num2 != 0)
                {
                    Result = num1 / num2;
                    Console.WriteLine($"\nThe division of {num1} and {num2} is : {Result}");
                }
                else
                {
                    Console.WriteLine("\nDivision by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("\nPlease Enter a Valid Sign and Number");
                break;
        }



        Console.ReadKey();
    }
}


