// Student.cs
using System;

public class Student : Person
{
    public string School { get; set; }

    // Constructor calling base constructor
    public Student(string name, int age, string school) : base(name, age)
    {
        // base means meebers from the parent class
        this.School = school;
    }

    // Method overriding to add additional functionality
    public override void DisplayInfo()
    {
        base.DisplayInfo(); // Call base class method
        Console.WriteLine($"School: {School}");
    }
}
