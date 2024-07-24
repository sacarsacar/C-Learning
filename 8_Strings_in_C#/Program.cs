// Strings:

internal class Program
{
    private static void Main(string[] args)
    {
        String FullName = "Sakar_Chaulagain";

        // Converting To Uppercase ( Use of uppercase):
        FullName = FullName.ToUpper();
        Console.WriteLine($" UpperCase: { FullName}");


        // Converting To LowerCase ( Use of Lowercase)
        FullName = FullName.ToLower();
        Console.WriteLine($"\n LowerCase: {FullName}");

        // Replacing Portions ( Use of Replace):
        FullName = FullName.Replace("_", " ");
        Console.WriteLine($"\n Replacement: {FullName}");


        // Creating Sub_String:
        String FirstName = FullName.Substring(0, 5);     //Here: 0 = Starting index And  5 = No. Of Characters 
        String LastName = FullName.Substring(6, 10);     //Here: 6 = Starting index And  10 = No. Of Characters 

        Console.WriteLine($"\nFirstName : {FirstName}");
        Console.WriteLine($"LastName : {LastName}");


        // Adding New Portion ( Use of Insert):
        String Name = FullName.Insert(0, "Mr. ");
        Console.WriteLine($"\nAdding New:  {Name}");

        
        // Length Property:
        Console.WriteLine("\nLength of Name: " + FullName.Length);

        Console.ReadKey();
    }
}