

using Chapter10_IndexersAndProperties;
using Chapter10_IndexersAndProperties.DynamicArray;
using Chapter10_IndexersAndProperties.Indexers;
using Chapter10_IndexersAndProperties.Properties;
using Chapter10_IndexersAndProperties.Properties.AccessMod;
using Chapter10_IndexersAndProperties.Properties.fail_soft;
using Chapter10_IndexersAndProperties.Properties.FailSoftFinalAuto;
using Chapter10_IndexersAndProperties.RangeArray;

class Program {
    static void Main()
    {
        TestIndexers();
        TestProperties();
        TestRangeArray();
        TestDynamicArray();
    }

    static void TestDynamicArray()
    {
        Console.WriteLine();
        Console.WriteLine("--DYNAMIC ARRAY--");
        DynamicArrayDemo.UseDynamicArray();
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