using System;

class Student
{
    public string Name;
    public int Age;

    // Default constructor.
    public Student()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Parameterized constructor.
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Another overloaded constructor.
    // It accepts only the student's name.

    public Student(string name)
    {
        Name = name;
        Age = 18;
    }
}

class ConstructorOverloading
{
    static void Main()
    {
        // Calling the default constructor.
        Student student1 = new Student();

        // Calling the parameterized constructor.
        Student student2 = new Student("Adesh", 21);

        // Calling another overloaded constructor.
        Student student3 = new Student("Rahul");

        Console.WriteLine(student1.Name + " - " + student1.Age);
        Console.WriteLine(student2.Name + " - " + student2.Age);
        Console.WriteLine(student3.Name + " - " + student3.Age);
    }
}