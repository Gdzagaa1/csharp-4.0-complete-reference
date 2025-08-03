

using Chapter09_OperatorOverloading.BinaryOverload;
using Chapter09_OperatorOverloading.Nybble;

class Program {
    static void Main()
    {
        //TestThreeD();
        TestNybble();
    }

    static void TestNybble()
    {
        Console.WriteLine("--Nybble--");
        NybbleDemo.useNybble();
        Console.WriteLine();
    }

    static void TestThreeD()
    {
        Console.WriteLine("--ThreeD Binary--");
        ThreeDDemo.useThreeD();
        Console.WriteLine();
    }
}

