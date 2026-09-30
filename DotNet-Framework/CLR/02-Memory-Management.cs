using System;

class MemoryManagement
{
    static void Main()
    {
        // CLR manages memory automatically.
        // We don't normally need to manually free objects
        // like we do in languages such as C/C++.

        Student student = new Student();

        student.Name = "Rahul";

        Console.WriteLine(student.Name);

        // The Student object is created in managed memory.
        //
        // When the object is no longer being used,
        // the .NET Garbage Collector (GC), which works
        // under the CLR, can reclaim its memory.

        student = null;

        // The object previously referenced by 'student'
        // is now eligible for garbage collection.
    }
}

class Student
{
    public string Name;
}