namespace Chapter09_OperatorOverloading.BinaryOverload;

public class ThreeDDemo
{
    public static void useThreeD()
    {

        testOperMethodOverload();
        testTrueAndFalseOverload();
        testLogical();
        testConversion();
    }

    static void testConversion()
    {
        Console.WriteLine("");
        Console.WriteLine("Implicit conversion:");
        Console.WriteLine("");

        ThreeD a = new ThreeD(1, 2, 3);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c = new ThreeD();
        int i;
        
        Console.Write("Here is a: ");
        a.Show();
        Console.WriteLine();
        Console.Write("Here is b: ");
        b.Show();
        Console.WriteLine();
        
        c = a + b; // add a and b together
        Console.Write("Result of a + b: ");
        c.Show();
        
        Console.WriteLine();
        
        i = a; // convert to int
        Console.WriteLine("Result of i = a: " + i);
        Console.WriteLine();
        
        i = a * 2 - b; // convert to int
        Console.WriteLine("result of a * 2 - b: " + i);
    }

    static void testLogical()
    {
        Console.WriteLine("");
        Console.WriteLine("LogicalOp overload:");
        Console.WriteLine("");
        
        ThreeD a = new ThreeD(5, 6, 7);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c = new ThreeD(0, 0, 0);
        
        Console.Write("Here is a: ");
        a.Show();
        Console.Write("Here is b: ");
        b.Show();
        Console.Write("Here is c: ");
        c.Show();
        Console.WriteLine();
        
        if(a) Console.WriteLine("a is true.");
        if(b) Console.WriteLine("b is true.");
        if(c) Console.WriteLine("c is true.");
        
        if(!a) Console.WriteLine("a is false.");
        if(!b) Console.WriteLine("b is false.");
        if(!c) Console.WriteLine("c is false.");
        
        Console.WriteLine();
        
        Console.WriteLine("Use & and |");
        if(a & b) Console.WriteLine("a & b is true.");
        else Console.WriteLine("a & b is false.");
        
        if(a & c) Console.WriteLine("a & c is true.");
        else Console.WriteLine("a & c is false.");
        
        if(a | b) Console.WriteLine("a | b is true.");
        else Console.WriteLine("a | b is false.");
        
        if(a | c) Console.WriteLine("a | c is true.");
        else Console.WriteLine("a | c is false.");
        
        Console.WriteLine();
        
        // Now use short-circuit ops.
        Console.WriteLine("Use short-circuit && and ||");
        if(a && b) Console.WriteLine("a && b is true.");
        else Console.WriteLine("a && b is false.");
        
        if(a && c) Console.WriteLine("a && c is true.");
        else Console.WriteLine("a && c is false.");
        
        if(a || b) Console.WriteLine("a || b is true.");
        else Console.WriteLine("a || b is false.");
        
        if(a || c) Console.WriteLine("a || c is true.");
        else Console.WriteLine("a || c is false.");
    }

    static void testTrueAndFalseOverload()
    {
        Console.WriteLine("");
        Console.WriteLine("True and False overload:");
        Console.WriteLine("");
        
        ThreeD a = new ThreeD(5, 6, 7);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c = new ThreeD(0, 0, 0);
        
        Console.Write("Here is a: ");
        a.Show();
        Console.Write("Here is b: ");
        b.Show();
        Console.Write("Here is c: ");
        c.Show();
        Console.WriteLine();
        
        if(a) Console.WriteLine("a is true.");
        else Console.WriteLine("a is false.");
        
        if(b) Console.WriteLine("b is true.");
        else Console.WriteLine("b is false.");
        
        if(c) Console.WriteLine("c is true.");
        else Console.WriteLine("c is false.");
        
        Console.WriteLine();
        
        Console.WriteLine("Control a loop using a ThreeD object.");
        do {
            b.Show();
            b--;
        } while(b);
    }
 
    static void testOperMethodOverload()
    {
        Console.WriteLine("Operator method overload:");
        Console.WriteLine("");
        ThreeD a = new ThreeD(1, 2, 3);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c = new ThreeD();
        
        Console.Write("Here is a: ");
        a.Show();
        Console.WriteLine();
        Console.Write("Here is b: ");
        b.Show();
        Console.WriteLine();
        
        c = a + b; // ThreeD + ThreeD
        Console.Write("Result of a + b: ");
        c.Show();
        Console.WriteLine();
        
        c = b + 10; // ThreeD + int
        Console.Write("Result of b + 10: ");
        c.Show();
        Console.WriteLine();
        
        c = 15 + b; // int + ThreeD
        Console.Write("Result of 15 + b: ");
        c.Show();

    }
    
}