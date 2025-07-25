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
        
        Console.WriteLine("--Ref Demo--");
        refOut.RefDemo();
        
        Console.WriteLine("--Swap--");
        refOut.SwapDemo();
    }
}

