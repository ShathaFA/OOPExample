// Animal.cs
using System;

public abstract class Animal
{
    public abstract void MakeSound(); // Abstract method

    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
     public string Name { get; set; } // Property common to all animals

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

   
    
}
