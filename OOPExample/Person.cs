// Person.cs
using System;

public class Person
{
    // Private field
    private string name;

    // Public property with getter and setter
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
        }
    }

    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    // Method to display person's info
    public virtual void DisplayInfo()
{
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Age: {Age}");
}
}
