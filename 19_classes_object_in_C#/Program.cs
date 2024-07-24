//class:
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");

        // Acessing from Different file ----- (Class1.cs) this is known as Classes
        Messages.Hello(); 
        Messages.Waiting();
        Messages.Bye();

        // Acessing From Different file ----(Object.cs) This is example of objects
        Human human1 = new Human();

        // Initilizating Variables for Objects:
        human1.Name = "Sakar Chaulagain";
        human1.Age = 18;
       //Calling objects
        human1.name();
        human1.age();
        human1.birthday();


        // You can create multiple object classes for eg:
        Human human2 = new Human();

                        // Initilizating Variables for Objects:
        human2.Name = "Sacar Sacars";
        human2.Age = 20;
                        //Calling objects
        human2.name();
        human2.age();
        human2.birthday();

        Console.ReadKey();
    }

}