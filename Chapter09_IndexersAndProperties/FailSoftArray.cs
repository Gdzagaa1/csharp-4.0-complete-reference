namespace Chapter09_IndexersAndProperties;


// Use an indexer to create a fail-soft array.
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