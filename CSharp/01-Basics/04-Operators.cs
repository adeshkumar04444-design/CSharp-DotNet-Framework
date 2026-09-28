using System;

class Operators
{
    static void Main()
    {
        int a = 10;
        int b = 3;

        // ==========================================
        // 1. ARITHMETIC OPERATORS
        // ==========================================
        //
        // +  Addition
        // -  Subtraction
        // *  Multiplication
        // /  Division
        // %  Modulus (remainder)

        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Remainder: " + (a % b));


        // ==========================================
        // 2. RELATIONAL / COMPARISON OPERATORS
        // ==========================================
        //
        // These operators compare two values.
        //
        // ==  Equal to
        // !=  Not equal to
        // >   Greater than
        // <   Less than
        // >=  Greater than or equal to
        // <=  Less than or equal to

        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a != b: " + (a != b));
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
        Console.WriteLine("a >= b: " + (a >= b));
        Console.WriteLine("a <= b: " + (a <= b));


        // ==========================================
        // 3. LOGICAL OPERATORS
        // ==========================================
        //
        // &&  Logical AND
        // ||  Logical OR
        // !   Logical NOT

        bool x = true;
        bool y = false;

        Console.WriteLine("x && y: " + (x && y));
        Console.WriteLine("x || y: " + (x || y));
        Console.WriteLine("!x: " + (!x));


        // ==========================================
        // 4. ASSIGNMENT OPERATORS
        // ==========================================
        //
        // =   Assign
        // +=  Add and assign
        // -=  Subtract and assign
        // *=  Multiply and assign
        // /=  Divide and assign

        int number = 10;

        number += 5; // Same as: number = number + 5
        Console.WriteLine("After += : " + number);

        number -= 3; // Same as: number = number - 3
        Console.WriteLine("After -= : " + number);

        number *= 2; // Same as: number = number * 2
        Console.WriteLine("After *= : " + number);

        number /= 4; // Same as: number = number / 4
        Console.WriteLine("After /= : " + number);


        // ==========================================
        // 5. INCREMENT AND DECREMENT
        // ==========================================

        int count = 5;

        count++; // Increases value by 1
        Console.WriteLine("After increment: " + count);

        count--; // Decreases value by 1
        Console.WriteLine("After decrement: " + count);
    }
}