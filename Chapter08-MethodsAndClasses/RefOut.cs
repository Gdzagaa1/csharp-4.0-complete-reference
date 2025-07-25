namespace Chapter08_MethodsAndClasses;

/*
 * Examples/Exercises of ref and out parameters.
 */
public class RefOut
{
    
    /*
     * An argument passed by ref must
     * be assigned a value prior to the call
     */
    
    
    // Swap two values.
    private void Swap(ref int a, ref int b) {
        int t;
        t = a;
        a = b;
        b = t;
    }

    public void SwapDemo() {
        int x = 10, y = 20;
        Console.WriteLine("x and y before call: " + x + " " + y);
        Swap(ref x, ref y);
        Console.WriteLine("x and y after call: " + x + " " + y);
    }
    

    // Use ref to pass a value type by reference
    private void Sqr(ref int i) {
        i = i * i;
    }
    
    public void RefDemo() {
        int a = 10;
        Console.WriteLine("a before call: " + a);
        Sqr(ref a);
        Console.WriteLine("a after call: " + a);
    }
}