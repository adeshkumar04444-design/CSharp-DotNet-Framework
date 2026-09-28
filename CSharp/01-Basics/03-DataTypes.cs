using System;

class DataTypes
{
    static void Main()
    {
        // A data type tells C# what kind of data
        // a variable can store.

        // ==============================
        // VALUE TYPES
        // ==============================

        // int stores whole numbers.
        int age = 21;

        // long stores larger whole numbers than int.
        long population = 1400000000;

        // float stores decimal numbers.
        // 'f' is required when assigning a float literal.
        float temperature = 36.5f;

        // double stores decimal numbers
        // with more precision than float.
        double price = 999.99;

        // decimal is commonly used when
        // high precision is required, such as money.
        decimal salary = 25000.50m;

        // char stores a single character.
        char grade = 'A';

        // bool stores either true or false.
        bool isPassed = true;


        // ==============================
        // REFERENCE TYPES
        // ==============================

        // string stores a sequence of characters.
        string name = "Adesh";

        // object is the base type of all C# types.
        object value = "Hello";


        // Displaying the values
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Population: " + population);
        Console.WriteLine("Temperature: " + temperature);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Passed: " + isPassed);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Object Value: " + value);
    }
}