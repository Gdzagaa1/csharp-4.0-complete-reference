namespace Chapter09_OperatorOverloading.BinaryOverload;

// An example of operator overloading.
// Overload addition for ThreeD + ThreeD, and for ThreeD + int.
public class ThreeD
{
    int x, y, z; // 3-D coordinates

    public ThreeD()
    {
        x = y = z = 0;
    }

    public ThreeD(int i, int j, int k)
    {
        x = i; y = j; z = k;
    }
    
    // An implicit conversion from ThreeD to int.
    public static implicit operator int(ThreeD op1)
    {
        return op1.x * op1.y * op1.z;
    }
    
    // // This is now explicit.
    // public static explicit operator int(ThreeD op1)
    // {
    //     return op1.x * op1.y * op1.z;
    // }
    
    // Overload binary +.
    public static ThreeD operator +(ThreeD op1, ThreeD op2)
    {
        ThreeD result = new ThreeD();
        /* This adds together the coordinates of the two points
            and returns the result. */
        result.x = op1.x + op2.x; // These are integer additions
        result.y = op1.y + op2.y; // and the + retains its original
        result.z = op1.z + op2.z; // meaning relative to them.
        return result;
    }
    
    // Overload binary + for object + int.
    public static ThreeD operator +(ThreeD op1, int op2)
    {
        ThreeD result = new ThreeD();
        result.x = op1.x + op2;
        result.y = op1.y + op2;
        result.z = op1.z + op2;
        return result;
    }
    
    // Overload binary + for int + ThreeD.
    public static ThreeD operator +(int op1, ThreeD op2)
    {
        ThreeD result = new ThreeD();
        result.x = op2.x + op1;
        result.y = op2.y + op1;
        result.z = op2.z + op1;
        return result;
    }
    
    // Overload binary -.
    public static ThreeD operator -(ThreeD op1, ThreeD op2)
    {
        ThreeD result = new ThreeD();
        /* Notice the order of the operands. op1 is the left
            operand and op2 is the right. */
        result.x = op1.x - op2.x; // these are integer subtractions
        result.y = op1.y - op2.y;
        result.z = op1.z - op2.z;
        return result;
    }
    
    // Overload unary --.
    public static ThreeD operator --(ThreeD op)
    {
        ThreeD result = new ThreeD();
        // Return the decremented result.
        result.x = op.x - 1;
        result.y = op.y - 1;
        result.z = op.z - 1;
        return result;
    }

    
    // Overload true.
    public static bool operator true(ThreeD op) {
        if((op.x != 0) || (op.y != 0) || (op.z != 0))
            return true; // at least one coordinate is non-zero
        else
            return false;
    }
    
    // Overload false.
    public static bool operator false(ThreeD op) {
        if((op.x == 0) && (op.y == 0) && (op.z == 0))
            return true; // all coordinates are zero
        else
            return false;
    }
    
    // Overload | for short-circuit evaluation.
    public static ThreeD operator |(ThreeD op1, ThreeD op2)
    {
        if( ((op1.x != 0) || (op1.y != 0) || (op1.z != 0)) |
            ((op2.x != 0) || (op2.y != 0) || (op2.z != 0)) )
            return new ThreeD(1, 1, 1);
        else
            return new ThreeD(0, 0, 0);
    }
    
    // Overload & for short-circuit evaluation.
    public static ThreeD operator &(ThreeD op1, ThreeD op2)
    {
        if( ((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) &
            ((op2.x != 0) && (op2.y != 0) && (op2.z != 0)) )
            return new ThreeD(1, 1, 1);
        else
            return new ThreeD(0, 0, 0);
    }
    
    // Overload !.
    public static bool operator !(ThreeD op)
    {
        if(op) return false;
        else return true;
    }

 
    // Show X, Y, Z coordinates.
    public void Show()
    {
        Console.WriteLine(x + ", " + y + ", " + z);
    }
}