using Chapter08_MethodsAndClasses;

class Program
{
    static void Main()
    {
        TestRefOut();
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

