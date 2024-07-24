using System;

internal class Program
{
    static void Main(string[] args)
    {
        Cow cow = new Cow();
        Dog dog = new Dog();
        Cat cat = new Cat();

        cow.voice(); // using virtual method
        dog.voice();
        
        Console.WriteLine(cat.ToString());  // using ToString() method

        Console.ReadKey();
    }
}

// Base class
class Animal
{
    // virtual method for overriding
    public virtual void voice()
    {
        Console.WriteLine("The Animal voice is like: meow");
    }
}

// Derived class Cow
class Cow : Animal
{
    public override void voice()
    {
        Console.WriteLine("Voice of Cow is like: baaaa");
    }
}

// Derived class Dog
class Dog : Animal
{
    public override void voice()
    {
        Console.WriteLine("Voice of Dog is like: bhau bhau");
    }
}

// Derived class Cat  { Using ToString() }
class Cat : Animal
{
public override string ToString()
     {
         return "Voice of Cat is like: *Meow*";
     }
 }
