// generics <T> = print any data type at once!
using System.ComponentModel.DataAnnotations;

internal class Program
{
    static void Main(string[] args)
    {

        int[] intArray = { 1, 2, 3, 4, 5 };
        String[] stringArray = { "Sakar", "Sacar" };
        double[] doubleArray = { 6.5, 7.5, 8.8, 9.2 };

        displayElements(intArray);
        displayElements(stringArray);
        displayElements(doubleArray);

        Console.ReadKey();
    }


    // Displaying all array elements at once: using <T>
    public static void displayElements<T>(T[] array)
    {
        foreach (T t in array)
        {
            Console.WriteLine(t + " ");
        }
        Console.WriteLine();
    }

    


    // Displaying Without using Generics :

   // displaying string:
    public static void displayElements(String[] array)
    {
        foreach (String name in array)
        {
            Console.WriteLine(name + " ");
        }
        Console.WriteLine();
    }

    // displaying int :
    public static void displayElements(int[] array)
    {
        foreach (int num in array)
        {
            Console.WriteLine(num + " ");
        }
        Console.WriteLine();
    }

    // displaying double :
    public static void displayElements(double[] array)
    {
        foreach (double deci in array)
        {
            Console.WriteLine(deci + " ");
        }
        Console.WriteLine();
    }

}

          // Note: Use of generics reduce lines of code!