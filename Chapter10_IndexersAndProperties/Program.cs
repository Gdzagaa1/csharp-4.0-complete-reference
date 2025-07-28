

using Chapter09_IndexersAndProperties;

class Program {
    static void Main()
    {
        TestIndexers();
    }

    static void TestIndexers()
    {
        Console.WriteLine("--FS INDEXERS--");
        FSDemo.fs();
        Console.WriteLine();
        Console.WriteLine("--FS INDEXERS OVERLOAD--");
        FSDemo.fsOverload();
    }
}