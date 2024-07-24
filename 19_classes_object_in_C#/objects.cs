using System;

public class Human
{
	public string Name;
	public int Age;

	public void name()
	{
        Console.WriteLine("\n*****This Message is From Different File (object.cs) ***** :\n");
        Console.WriteLine(Name + " is Having Food.");
	}

	public void age()
	{
		Console.WriteLine("You are " + Age + " Years Old!");
	}

	public void birthday()
	{
		Console.WriteLine("Happy Birthday To You " + Name);
        Console.WriteLine("\n*******************************\n");
    }
}
