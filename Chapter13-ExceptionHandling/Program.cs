// See https://aka.ms/new-console-template for more information

using Chapter13_ExceptionHandling.Exc;
using Chapter13_ExceptionHandling.Nested;

class Program
{
    static void Main()
    {
        testExc();
        testNested();
    }

    static void testNested()
    {
        Console.WriteLine("-- Nested --");
        NestTrys.nest();
        Console.WriteLine("");
    }

    static void testExc()
    {
        Console.WriteLine("-- EXC --");
        ExcDemo.test();
        Console.WriteLine("");
    }
}
