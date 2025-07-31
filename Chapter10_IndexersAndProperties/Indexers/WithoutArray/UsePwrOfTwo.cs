namespace Chapter10_IndexersAndProperties.Indexers;

public class UsePwrOfTwo
{
    public static void usePwr() {
        PwrOfTwo pwr = new PwrOfTwo();
        Console.Write("First 8 powers of 2: ");
        
        for(int i = 0; i < 8; i++)
            Console.Write(pwr[i] + " ");
        
        Console.WriteLine();
        Console.Write("Here are some errors: ");
        Console.Write(pwr[-1] + " " + pwr[17]);
        Console.WriteLine();
    }
}