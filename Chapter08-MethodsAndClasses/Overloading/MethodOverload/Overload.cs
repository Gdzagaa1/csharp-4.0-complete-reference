namespace Chapter08_MethodsAndClasses.Overloading;

/*
 * OvlDemo( ) is overloaded four times. The first version takes no parameters;
 * the second takes one integer parameter; the third takes two integer parameters; and the
 * fourth takes two double parameters.
 *
 * Soo, overloading is not affected one way or the other by the return type of method.
 */

public class Overload
{
    public void OvlDemo() {
        Console.WriteLine("No parameters");
    }
    
    // Overload OvlDemo for one integer parameter.
    public void OvlDemo(int a) {
        Console.WriteLine("One parameter: " + a);
    }

    // Overload OvlDemo for two integer parameters.
    public int OvlDemo(int a, int b) {
        Console.WriteLine("Two parameters: " + a + " " + b);
        return a + b;
    }
    
    // Overload OvlDemo for two double parameters.
    public double OvlDemo(double a, double b) {
        Console.WriteLine("Two double parameters: " +
                          a + " "+ b);
        return a + b;
    }
}