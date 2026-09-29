using System;

class NamedArguments
{
    static void Main()
    {
        // Named arguments allow us to specify
        // parameter names while calling a method.

        StudentInfo(
            name: "Adesh",
            age: 21,
            course: "BCA"
        );
    }

    static void StudentInfo(
        string name,
        int age,
        string course)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Course: " + course);
    }
}