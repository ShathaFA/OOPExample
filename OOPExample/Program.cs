// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Encapsulation and Abstraction
        Console.WriteLine("Encapsulation and Abstraction");
        Person person = new Person("Alice", 30);
        person.DisplayInfo();
        
        // Inheritance and Polymorphism
        Console.WriteLine("Inheritance and Polymorphism");
        Student student = new Student("Bob", 20, "University of XYZ");
        student.DisplayInfo();
        
        // Abstraction
        Console.WriteLine("Abstraction");
        Animal dog = new Dog();
        dog.MakeSound();
        dog.Sleep();
    }
}
