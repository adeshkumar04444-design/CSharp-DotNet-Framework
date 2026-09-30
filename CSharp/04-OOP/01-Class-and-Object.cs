using System;

// A class is a blueprint or template for creating objects.
// It defines the data and behavior that an object can have.

class Student
{
    // Fields store data inside a class.
    public string Name;
    public int Age;

    // This method defines the behavior of the Student object.
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class ClassAndObject
{
    static void Main()
    {
        // An object is an instance of a class.
        // The 'new' keyword creates an object in memory.

        Student student1 = new Student();

        // Assigning values to the object's fields.
        student1.Name = "Adesh";
        student1.Age = 21;

        // Calling the method using the object.
        student1.DisplayInfo();
    }
}