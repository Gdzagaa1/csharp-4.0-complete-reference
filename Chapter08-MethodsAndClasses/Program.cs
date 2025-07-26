using Chapter08_MethodsAndClasses;
using Chapter08_MethodsAndClasses.Overloading;


class Program
{
    static void Main()
    {
        //TestRefOut();
        //TestFindFactors();
        //TestParams();
        //TestFactory();
        TestOverloading();
    }

    static void TestOverloading()
    {
        Console.WriteLine("--Overload Demo--");
        OverloadDemo od = new OverloadDemo();
        od.ovlDemo();

        Console.WriteLine("");
        Console.WriteLine("--Stack Overload Constructor--");
        StackDemo sd = new StackDemo();
        sd.useStack();
        
        Console.WriteLine("");
        Console.WriteLine("--XYCoord, this--");
        OverloadConsDemo overloadCons = new OverloadConsDemo();
        overloadCons.callXY();

    }

    static void TestFindFactors()
    {
        FindFactors findFactors = new FindFactors();
        
        Console.WriteLine("--Find Factors--");
        findFactors.find();
    }

    static void TestFactory()
    {
        MakeObjects obj = new MakeObjects();
        
        Console.WriteLine("--FactoryDemo--");
        obj.make();
    }

    static void TestParams()
    {
        ParamsDemo paramsDemo = new ParamsDemo();
        
        Console.WriteLine("--ParamsDemo--");
        paramsDemo.Param();
    }

    static void TestRefOut()
    {
        RefOut refOut = new RefOut();
        
        Console.WriteLine("--RefDemo/sqr--");
        refOut.RefDemo();
        
        Console.WriteLine("--Swap--");
        refOut.SwapDemo();
        
        Console.WriteLine("--UseOut--");
        refOut.UseOut();
        
        Console.WriteLine("--Common Factor--");
        refOut.DemoOut();
        
        Console.WriteLine("--RefSwap--");
        refOut.RefSwapDemo();
    }
}

