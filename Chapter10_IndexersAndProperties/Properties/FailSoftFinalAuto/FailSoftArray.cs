namespace Chapter10_IndexersAndProperties.Properties.FailSoftFinalAuto;

// Use read-only, auto-implemented properties for Length and Error.

public class FailSoftArray
{
    int[] a; // reference to underlying array
    
    // Construct array given its size.
    public FailSoftArray(int size) {
        a = new int[size];
        Length = size;
    }
    
    // An auto-implemented, read-only Length property.
    public int Length { get; private set; }

    // An auto-implemented, read-only Error property.
    public bool Error { get; private set; }
    
    // This is the indexer for FailSoftArray.    
    public int this[int index] {
        get {
            if(ok(index)) {
                Error = false;
                return a[index];
            } else {
                Error = true;
                return 0;
            }
        }

        set {
            if(ok(index)) {
                a[index] = value;
                Error = false;
            }
            else Error = true;
        }
    }
    
    // Return true if index is within bounds.
    private bool ok(int index) {
        if(index >= 0 & index < Length) return true;
        return false;
    }
}