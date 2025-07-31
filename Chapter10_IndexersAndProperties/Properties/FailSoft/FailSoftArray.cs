namespace Chapter09_IndexersAndProperties.Properties.fail_soft;


// Add Length property to FailSoftArray.

public class FailSoftArray
{
    int[] a; // reference to underlying array
    int len; // length of array -- underlies Length property
    bool ErrFlag; // indicates outcome of last operation
    
    // Construct array given its size.
    public FailSoftArray(int size) {
        a = new int[size];
        len = size;
    }
    
    // Read-only Length property.
    public int Length {
        get {
            return len;
        }
    }
    
    // Read-only Error property.
    public bool Error {
        get {
            return ErrFlag;
        }
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