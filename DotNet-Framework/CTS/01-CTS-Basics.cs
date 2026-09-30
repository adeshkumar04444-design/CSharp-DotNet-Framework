using System;

class CTSBasics
{
    static void Main()
    {
        // CTS stands for Common Type System.
        //
        // CTS defines how data types are declared,
        // used, and managed in the .NET environment.
        //
        // It provides a common type system for .NET languages
        // such as C#, VB.NET and F#.
        //
        // This allows different .NET languages to work
        // with compatible data types.

        int age = 21;
        double height = 1.70;
        bool isStudent = true;
        string name = "Adesh";

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(height);
        Console.WriteLine(isStudent);
    }
}