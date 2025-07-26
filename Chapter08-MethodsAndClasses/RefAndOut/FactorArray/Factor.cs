namespace Chapter08_MethodsAndClasses;


// Return an array.

public class Factor
{
    /* Return an array containing the factors of num.
    On return, numfactors will contain the number of
    factors found. */
    
    public int[] FindFactors(int num, out int numfactors) {
        int[] facts = new int[80];
        int i, j;
        
        for(i = 2, j = 0; i < num / 2 + 1; i++)
            if( (num % i) == 0 ) {
                facts[j] = i;
                j++;
            }
        numfactors = j;
        return facts;
    }
}