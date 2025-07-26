namespace Chapter08_MethodsAndClasses.Overloading;


/*
 * Example of this keyword.
 * Here the only constructor that actually
 * initializes the x and y fields is XYCoord(int, int).
 * The other two constructors simply invoke
 * XYCoord(int, int) through this.
 */
public class XYCoord
{
    public int x, y;
    
    public XYCoord() : this(0, 0) {
        Console.WriteLine("Inside XYCoord()");
    }
    public XYCoord(XYCoord obj) : this(obj.x, obj.y) {
        Console.WriteLine("Inside XYCoord(obj)");
    }
    public XYCoord(int i, int j) {
        Console.WriteLine("Inside XYCoord(int, int)");
        x = i;
        y = j;
    }
}