

using Chapter09_IndexersAndProperties;
using Chapter09_IndexersAndProperties.Indexers;

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
        
        Console.WriteLine();
        Console.WriteLine("--Indexer without array--");
        UsePwrOfTwo.usePwr();
        
        
    }
}