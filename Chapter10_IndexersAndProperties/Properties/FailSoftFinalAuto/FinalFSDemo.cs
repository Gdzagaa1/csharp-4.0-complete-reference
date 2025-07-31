namespace Chapter10_IndexersAndProperties.Properties.FailSoftFinalAuto;

public class FinalFSDemo
{
    public static void useFinalFs()
    {
        FailSoftArray fs = new FailSoftArray(5);
        // Use Error property.
        for (int i = 0; i < fs.Length + 1; i++)
        {
            fs[i] = i * 10;
            if (fs.Error)
                Console.WriteLine("Error with index " + i);
        }
    }
}