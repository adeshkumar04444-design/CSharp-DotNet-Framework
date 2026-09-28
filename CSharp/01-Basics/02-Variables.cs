using System;

class Variables
{
    static void Main()
    {
        // A variable is a named memory location
        // used to store data.

        // Syntax:
        // dataType variableName = value;

        string name = "Adesh";
        int age = 21;
        double height = 1.70;
        bool isStudent = true;

        // Printing variables
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Student: " + isStudent);

        // A variable's value can be changed later.
        age = 22;

        Console.WriteLine("Updated Age: " + age);

        // Important:
        // A variable must have a compatible data type.
        // Example:
        // int marks = 90;       // Valid
        // string name = "Adesh"; // Valid
    }
}