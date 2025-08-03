namespace Chapter09_OperatorOverloading.Nybble;


/*
 * The following example uses the Nybble class to implement
 * a nybble data type. It uses
 * an int for its underlying storage, but it restricts 
 * the values that can be held to 0 through 15.
 * It defines the following operators:
 *  • Addition of a Nybble to a Nybble
 *  • Addition of an int to a Nybble
 *  • Addition of a Nybble to an int
 *  • Greater than and less than
 *  • The increment operator
 *  • Conversion to Nybble from int
 *  • Conversion to int from Nybble
 */


public class Nybble
{
    int val; // underlying storage
    
    public const int MinValue = 0;
    public const int MaxValue = 15;
    
    public Nybble() { val = 0; }
    public Nybble(int i) {
        if (i < MinValue || i > MaxValue)
            throw new OverflowException($"Value {i} is outside the valid Nybble range ({MinValue}-{MaxValue})");
        val = i;
    }
    
    private static void ValidateRange(int value)
    {
        if (value < MinValue || value > MaxValue)
            throw new OverflowException($"Operation result {value} is outside the valid Nybble range ({MinValue}-{MaxValue})");
    }
    
    // Overload binary + for Nybble + Nybble.
    public static Nybble operator +(Nybble op1, Nybble op2)
    {
        int result = op1.val + op2.val;
        ValidateRange(result);
        return new Nybble(result);
    }
    
    // Overload binary + for Nybble + int.
    public static Nybble operator +(Nybble op1, int op2)
    {
        int result = op1.val + op2;
        ValidateRange(result);
        return new Nybble(result);
    }
    
    // Overload binary + for int + Nybble.
    public static Nybble operator +(int op1, Nybble op2)
    {
        int result = op1 + op2.val;
        ValidateRange(result);
        return new Nybble(result);
    }
    
    // Overload ++.
    public static Nybble operator ++(Nybble op)
    {
        int result = op.val + 1;
        ValidateRange(result);
        return new Nybble(result);
    }
    
    // Overload >.
    public static bool operator >(Nybble op1, Nybble op2)
    {
        if(op1.val > op2.val) return true;
        else return false;
    }
    
    // Overload <.
    public static bool operator <(Nybble op1, Nybble op2)
    {
        if(op1.val < op2.val) return true;
        else return false;
    }
    
    // Convert a Nybble into an int.
    public static implicit operator int (Nybble op)
    {
        return op.val;
    }
    
    // Convert an int into a Nybble.
    public static implicit operator Nybble (int op)
    {
        return new Nybble(op);
    }
}