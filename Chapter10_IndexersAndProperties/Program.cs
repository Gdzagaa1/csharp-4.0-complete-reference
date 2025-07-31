

using Chapter09_IndexersAndProperties;
using Chapter09_IndexersAndProperties.Indexers;
using Chapter09_IndexersAndProperties.Properties;
using Chapter09_IndexersAndProperties.Properties.AccessMod;
using Chapter09_IndexersAndProperties.Properties.fail_soft;
using Chapter09_IndexersAndProperties.Properties.FailSoftFinalAuto;
using Chapter09_IndexersAndProperties.RangeArray;

class Program {
    static void Main()
    {
        //TestIndexers();
        //TestProperties();
        TestRangeArray();
    }

    static void TestRangeArray()
    {
        Console.WriteLine();
        Console.WriteLine("--RANGE ARRAY--");
        RangeArrayDemo.useRangeArray();
    }

    static void TestProperties()
    {
        Console.WriteLine();
        Console.WriteLine("--SimpProp--");
        PropertyDemo.callSimpProp();
        
        Console.WriteLine();
        Console.WriteLine("--FS PROPERTIES--");
        ImprovedFSDemo.improveFs();
        
        Console.WriteLine();
        Console.WriteLine("--PropAccess--");
        PropAccessDemo.prop();
        
        Console.WriteLine();
        Console.WriteLine("--FS FINAL AUTO PROPERTIES--");
        FinalFSDemo.useFinalFs();
    }

    static void TestIndexers()
    {
        Console.WriteLine();
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