

using Chapter09_IndexersAndProperties;
using Chapter09_IndexersAndProperties.Indexers;
using Chapter09_IndexersAndProperties.Properties;
using Chapter09_IndexersAndProperties.Properties.fail_soft;

class Program {
    static void Main()
    {
        //TestIndexers();
        TestProperties();
    }

    static void TestProperties()
    {
        Console.WriteLine("--SimpProp--");
        PropertyDemo.callSimpProp();
        
        Console.WriteLine("--FS PROPERTIES");
        ImprovedFSDemo.improveFs();
            
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