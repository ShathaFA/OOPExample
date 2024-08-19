// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Encapsulation 
        Console.WriteLine("Encapsulation");
        Person person = new Person("Alice", 30);
        person.DisplayInfo();
        
        // Inheritance and Polymorphism
        Console.WriteLine("Inheritance and Polymorphism");
        Student student = new Student("Bob", 20, "University of XYZ");
        student.DisplayInfo();
        
        // Abstraction
        Console.WriteLine("Abstraction");
        Animal dog = new Dog();
        dog.Name = "Buddy";
         Console.WriteLine(dog.Name);

        dog.MakeSound();
        dog.Sleep();
        dog.Eat();
        
        IPlayable obj1=new MusicPlayer();
        obj1.Play();
        obj1.Stop();



    }
}
