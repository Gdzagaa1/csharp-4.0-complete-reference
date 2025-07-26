namespace Chapter08_MethodsAndClasses.Static;

public class StaticClassDemo
{
    public void testStatic() {
        Console.WriteLine("Reciprocal of 5 is " +
                          NumericFn.Reciprocal(5.0));
        
        Console.WriteLine("Fractional part of 4.234 is " +
                          NumericFn.FracPart(4.234));
        
        if(NumericFn.IsEven(10))
            Console.WriteLine("10 is even.");
        
        if(NumericFn.IsOdd(5))
            Console.WriteLine("5 is odd.");
        
        // The following attempt to create an instance of
        // NumericFn will cause an error.

        // NumericFn ob = new NumericFn(); // Wrong!
    }
}