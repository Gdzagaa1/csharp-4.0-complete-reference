namespace Chapter10_IndexersAndProperties.Properties.fail_soft;

public class ImprovedFSDemo
{
    public static void improveFs() {
        FailSoftArray fs = new FailSoftArray(5);
        int x;
        // Can read Length.
        for (int i = 0; i < fs.Length; i++)
        {
            fs[i] = i * 10;
        }

        for(int i = 0; i < fs.Length; i++) 
        {
            x = fs[i];
            if(x != -1) Console.Write(x + " ");
        }
        Console.WriteLine();
        // fs.Length = 10; // Error, illegal!
        
        // Use Error property.
        for(int i = 0; i < fs.Length + 1; i++) {
            fs[i] = i * 10;
            if(fs.Error)
                Console.WriteLine("Error with index " + i);
        }
    }
}