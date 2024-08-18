// Animal.cs
using System;

public abstract class Animal
{
    public abstract void MakeSound(); // Abstract method

    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}
