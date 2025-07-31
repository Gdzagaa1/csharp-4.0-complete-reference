namespace Chapter09_IndexersAndProperties.Properties.AccessMod;

public class PropAccessDemo
{
    public static void prop() {
        PropAccess ob = new PropAccess();
        Console.WriteLine("Original value of ob.MyProp: " + ob.MyProp);
        
        // ob.MyProp = 100; // can't access set
        
        ob.IncrProp();
        Console.WriteLine("Value of ob.MyProp after increment: " + ob.MyProp);
    }
}