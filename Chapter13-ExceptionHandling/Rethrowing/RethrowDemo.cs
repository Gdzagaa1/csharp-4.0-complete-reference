namespace Chapter13_ExceptionHandling.Rethrowing;

public class RethrowDemo
{
    public static void demo()
    {
        try
        {
            Rethrow.GenException();
        }
        catch (IndexOutOfRangeException)
        {
            // recatch exception
            Console.WriteLine("Fatal error -- " + "program terminated.");
        }
    }
}