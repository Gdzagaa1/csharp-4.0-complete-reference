namespace Chapter08_MethodsAndClasses;

/*
 * Demonstration of Params modifier.
 */
public class ParamsDemo
{
    public void Param() {
        int min;
        int a = 10, b = 20;
        min = MinVal(a, b);
        Console.WriteLine("Minimum is " + min);
        
        min = MinVal(a, b, -1);
        Console.WriteLine("Minimum is " + min);
        
        int[] args = { 45, 67, 34, 9, 112, 8 };
        min = MinVal(args);
        Console.WriteLine("Minimum is " + min);
    }



    private int MinVal(params int[] nums)
    {
            int m;
            if (nums.Length == 0)
            {
                    Console.WriteLine("Error: no arguments.");
                    return 0;
            }
           
        
            m = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < m) m = nums[i];
            }

            return m;
    }
    
}