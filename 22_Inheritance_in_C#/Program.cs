// inheritance:
internal class Program
{
    static void Main(String[] args)
    {
        // Accessing Child Classes:
        male Male = new male(); 
        female Female = new female();   
        others Others = new others();

        
        // printing values from different class ( child classes)
        Male.info();
        Console.WriteLine(Male.gender);
        Console.WriteLine("Male: " + Male.percentage + "%\n");

        Female.info();
        Console.WriteLine(Female.gender);
        Console.WriteLine("Female: " + Female.percentage + "%\n");

        Others.info();
        Console.WriteLine(Others.gender);
        Console.WriteLine("Others: " + Others.percentage + "% (No data Available!) \n");

        Console.ReadKey();
    }
    // here abstract  make class more secure! ,For more do some Research!
     abstract class People
    {
        // initilaization:
        public String gender = "Population Accroding to GENDER!";

        public void info()
        {
            Console.WriteLine("Data Accroding to 2022 Census Nepal! ");
        }
    }

    //Creating Child Classes:
    class male : People
    {
        public double percentage = 61.02;
    }

    class female : People
    {
        public double percentage = 38.98;
    }

    class others : People
    {
        public int percentage = 0;
    }
}