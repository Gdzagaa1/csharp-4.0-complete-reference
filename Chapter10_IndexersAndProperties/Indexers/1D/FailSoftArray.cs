namespace Chapter09_IndexersAndProperties;


// Use an indexer to create a fail-soft array.
// Also there is overloaded version.

public class FailSoftArray
{
    int[] a; // reference to underlying array
    public int Length; 
    public bool ErrFlag; // indicates outcome of last operation
    
    // Construct array given its size.
    public FailSoftArray(int size) {
        a = new int[size];
        Length = size;
    }
    
    // This is the indexer for FailSoftArray.
    public int this[int index] {
    
        get {
            if(ok(index)) {
                ErrFlag = false;
                return a[index];
            } else {
                ErrFlag = true;
                return 0;
            }
        }
        
        set {
            if(ok(index)) {
                a[index] = value;
                ErrFlag = false;
            } else {
                ErrFlag = true;
            }
        }
    }
    
    
    /* This is another indexer for FailSoftArray.
        This index takes a double argument. It then
        rounds that argument to the nearest integer index. */
    public int this[double idx] {

        get {
            int index;
            if( (idx - (int) idx) < 0.5) index = (int) idx;
            else index = (int) idx + 1;
            if(ok(index)) {
                ErrFlag = false;
                return a[index];
            } else {
                ErrFlag = true;
                return 0;
            }
        }

        set {
            int index;
            if( (idx - (int) idx) < 0.5) index = (int) idx;
            else index = (int) idx + 1;
            if(ok(index)) {
                a[index] = value;
                ErrFlag = false;
            }
            else ErrFlag = true;
        }
    }
    
    // Return true if index is within bounds.
    private bool ok(int index) {
        if(index >= 0 & index < Length) return true;
        return false;
    }
}