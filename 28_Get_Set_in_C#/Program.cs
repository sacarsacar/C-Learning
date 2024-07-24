// get :Read, Set: Write, value (keyword: assigning value using set)
internal class Program
{
  static void Main(string[] args)
    {

        Bike bike = new Bike(100);
        bike.Speed = 250; // Declearing Speed 


        Console.WriteLine(bike.Speed);

        Console.ReadKey();
    }
}

// Creating Class: 
class Bike
{
    private int speed;

    public Bike (int speed)
    {
        Speed = speed;
    }

    public int Speed
    {
        get { return speed; }   // Read

        set
        {
            // Checking Speed Limit
            if (value >300)
            {
                Console.Write("Speed Limit Reached i.e 300km/hr!");
            }
            else
            {
                Console.Write("Your speed is:");
               speed = value;  // call the upper value (speed:250)
            }
            
        }
    }
}
