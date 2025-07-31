namespace Chapter10_IndexersAndProperties;

/*
 * Demonstrate usage of FailSoftArray with indexers
 */
public class FSDemo
{
    public static void fs() {
        FailSoftArray fs = new FailSoftArray(5);
        int x;
        
        // Show quiet failures.
        Console.WriteLine("Fail quietly.");
        for(int i = 0; i < (fs.Length * 2); i++)
        {
            fs[i] = i * 10;    
        }
        
        
        for(int i = 0; i < (fs.Length * 2); i++) {
            x = fs[i];
            if(x != -1) Console.Write(x + " ");
        }
        
        Console.WriteLine();
        
        // Now, display failures.
        Console.WriteLine("\nFail with error reports.");
        for(int i = 0; i < (fs.Length * 2); i++) {
            fs[i] = i * 10;
            if(fs.ErrFlag)
                Console.WriteLine("fs[" + i + "] out-of-bounds");
        }
        
        for(int i = 0; i < (fs.Length * 2); i++) {
            x = fs[i];
            if(!fs.ErrFlag) Console.Write(x + " ");
            else
                Console.WriteLine("fs[" + i + "] out-of-bounds");
        }
    }
    
    
    
    
    public static void fsOverload() {
        FailSoftArray fs = new FailSoftArray(5);

        for(int i = 0; i < fs.Length; i++)
            fs[i] = i;

        Console.WriteLine("fs[1]: " + fs[1]);
        
        Console.WriteLine("fs[2]: " + fs[2]);
        Console.WriteLine("fs[1.1]: " + fs[1.1]);
        Console.WriteLine("fs[1.6]: " + fs[1.6]);
    }
}