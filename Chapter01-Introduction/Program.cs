using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Chapter 1: Introduction to C# ===");
        Console.WriteLine();
        
        HelloWorld();
        BasicVariables();
        SimpleCalculation();
    }
    
    static void HelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }
    
    static void BasicVariables()
    {
        string name = "C# Learner";
        int age = 25;
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
    
    static void SimpleCalculation()
    {
        int a = 10;
        int b = 20;
        int sum = a + b;
        Console.WriteLine($"{a} + {b} = {sum}");
    }
}