namespace Chapter09_IndexersAndProperties;

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
}