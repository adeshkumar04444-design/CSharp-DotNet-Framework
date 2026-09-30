using System;

class CLRBasics
{
    static void Main()
    {
        // CLR stands for Common Language Runtime.
        // It is the execution environment of .NET applications.
        //
        // When we write C# code, it is first compiled into
        // Intermediate Language (IL).
        //
        // CLR loads this IL code and uses JIT (Just-In-Time)
        // compilation to convert it into machine code.
        //
        // CLR also provides services such as:
        // 1. Memory management
        // 2. Exception handling
        // 3. Garbage collection
        // 4. Type safety
        // 5. Security
        // 6. Thread management

        Console.WriteLine("Hello from CLR!");

        // This C# statement is compiled into Intermediate Language.
        // CLR executes the resulting IL using the JIT compiler.
    }
}