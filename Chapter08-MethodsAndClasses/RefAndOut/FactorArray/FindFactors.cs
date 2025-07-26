namespace Chapter08_MethodsAndClasses;

public class FindFactors
{
    public void find() {
        Factor f = new Factor();
        int numfactors;
        int[] factors;
        factors = f.FindFactors(1000, out numfactors);
        Console.WriteLine("Factors for 1000 are: ");
        for (int i = 0; i < numfactors; i++)
        {
            Console.Write(factors[i] + " ");
        }
        
        Console.WriteLine();
    }
}