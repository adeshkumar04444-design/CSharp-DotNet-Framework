using System;

class ValueTypes
{
    static void Main()
    {
        // CTS divides .NET types into different categories.
        //
        // One important category is Value Types.
        //
        // Examples:
        // int
        // double
        // float
        // bool
        // char
        // struct
        // enum

        int number = 100;
        double price = 99.99;
        bool isAvailable = true;
        char grade = 'A';

        Console.WriteLine(number);
        Console.WriteLine(price);
        Console.WriteLine(isAvailable);
        Console.WriteLine(grade);
    }
}