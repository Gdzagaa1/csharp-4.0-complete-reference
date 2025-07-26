namespace Chapter08_MethodsAndClasses.Static;


// Demonstrate a static class.

static class NumericFn {
    
    // Return the reciprocal of a value.
    static public double Reciprocal(double num) {
        return 1/num;
    }
    // Return the fractional part of a value.
    static public double FracPart(double num) {
        return num - (int) num;
    }
    // Return true if num is even.
    static public bool IsEven(double num) {
        return (num % 2) == 0 ? true : false;
    }
    // Return true if num is odd.
    static public bool IsOdd(double num) {
        return !IsEven(num);
    }
}