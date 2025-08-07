namespace Chapter13_ExceptionHandling.Exc;

public class ExcTest
{
    // Generate an exception.
    public static void GenException() {
        int[] nums = new int[4];
        Console.WriteLine("Before exception is generated.");
        
        // Generate an index out-of-bounds exception.
        for(int i = 0; i < 10; i++) {
            nums[i] = i;
            Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
        }
        Console.WriteLine("this won't be displayed");
    }

}