using Chapter08_MethodsAndClasses;


class Program
{
    static void Main()
    {
        //TestRefOut();
        //TestParams();
        TestFactory();
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

