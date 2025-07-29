namespace Chapter09_IndexersAndProperties.Properties;

public class PropertyDemo
{
    public static void callSimpProp() {
        SimpProp ob = new SimpProp();
        Console.WriteLine("Original value of ob.MyProp: " + ob.MyProp);
        ob.MyProp = 100; // assign value
        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp);
        
        Console.WriteLine("Attempting to assign -10 to ob.MyProp");
        ob.MyProp = -10;
        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp);
    }
}