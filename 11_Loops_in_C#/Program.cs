using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // While Loop:
        string Name = "";   // initializating Empty String  

        while(Name == "") {              // Check String is empty or not ( Loop will not end until user name is entred)
            Console.Write("Enter Your Name:");
            Name = Console.ReadLine();          // User input

        }
        Console.WriteLine($"Hello {Name}");


        //for Loop:

        Console.WriteLine("\nPrinting Upto 10 using For loop:");

        for( int i = 1; i <= 10; i++)   // Here: int i = 1 : starting point, i <=10 : Ending point, i++ : increase the value of i by 1 every time until condtion meets.
        {
            Console.WriteLine(i);
        }


        // Nested loop: Using Loops inside loop (creating rectangle, square)

        Console.Write("\nEnter No. Of Rows:");
        int Row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter No. Of Columns:");
        int Column = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter any Symbol:");
        string symbol = Console.ReadLine();


        for( int i = 0; i < Row; i++)    // for row
        {
            for (int j = 0; j < Column; j++)      // for columns
            {
                Console.Write(symbol);
            }
            Console.WriteLine();   // print in new line after each row
        }

        Console.ReadKey();

    }
}