namespace Chapter09_IndexersAndProperties.Indexers;


/*
 * 1) Because an indexer does
 *    not define a storage location, a value produced
 *    by an indexer cannot be passed as a ref or
 *    out parameter to a method.
 * 2) an indexer must be an instance member of its class; it
*     cannot be declared static.
 */

// Indexers don't have to operate on actual arrays.
public class PwrOfTwo
{
    /* Access a logical array that contains
        the powers of 2 from 0 to 15. */
    public int this[int index] {
        get {
            if((index >= 0) && (index < 16)) return pwr(index);
            else return -1;
        }
    }
    
    int pwr(int p) {
        int result = 1;
        for(int i = 0; i < p; i++)
            result *= 2;
        return result;
    }
}