using System;

class Student
{
    public string Name;
    public int Age;

    // A constructor is a special method that runs
    // automatically when an object is created.

    // Important:
    // 1. Constructor name must be the same as the class name.
    // 2. Constructor does not have a return type.
    // 3. It is commonly used to initialize objects.

    public Student()
    {
        // Assigning default values when the object is created.
        Name = "Unknown";
        Age = 0;
    }
}

class Constructors
{
    static void Main()
    {
        // Creating an object automatically calls
        // the Student() constructor.

        Student student = new Student();

        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);
    }
}