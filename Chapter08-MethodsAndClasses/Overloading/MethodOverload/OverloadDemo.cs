namespace Chapter08_MethodsAndClasses.Overloading;

/*
 * Demonstrate Overload class
 */
public class OverloadDemo
{
    public void ovlDemo() {
        Overload ob = new Overload();
        int resI;
        double resD;

        ob.OvlDemo();
        Console.WriteLine();
        
        ob.OvlDemo(2);
        Console.WriteLine();
        
        resI = ob.OvlDemo(4, 6);
        Console.WriteLine("Result of ob.OvlDemo(4, 6): " + resI);
        
        Console.WriteLine();
        resD = ob.OvlDemo(1.1, 2.32);
        Console.WriteLine("Result of ob.OvlDemo(1.1, 2.32): " + resD);
    }
}