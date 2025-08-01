namespace Chapter09_OperatorOverloading.BinaryOverload;

public class ThreeDDemo
{
    public static void useThreeD() {
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