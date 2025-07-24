using System;
using Chapter07_ArraysAndStrings;

class Program
{
    static void Main(string[] args)
    {
        TestTwoSum();
    }
    
    static void TestTwoSum()
    {
        int[] nums = {2, 7, 11, 15};
        int target = 9;
        int[] result = TwoSum.Solution(nums, target);
        Console.WriteLine(result[0] + " " + result[1]);
    }

}