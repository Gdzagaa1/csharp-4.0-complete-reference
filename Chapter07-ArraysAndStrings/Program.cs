using System;
using Chapter07_ArraysAndStrings;
using Chapter07_ArraysAndStrings.Multi_Jagged;

class Program
{
    static void Main(string[] args)
    {
        //TestArrays();
        TestMultiJagged();
    }

    static void TestMultiJagged()
    {
        Console.WriteLine("--TwoD--");
        ExamplesMultiAndJagged.TwoD();
        
        Console.WriteLine("--ThreeDMatrix--");
        ExamplesMultiAndJagged.ThreeDMatrix();
        
        Console.WriteLine("--Squares--");
        ExamplesMultiAndJagged.Squares();
    }



    static void TestArrays()
    {
        int[] nums = {2, 7, 11, 15};
        int target = 9;
        int[] result = TwoSum.Solution(nums, target);
        Console.WriteLine("--TwoSum--");
        Console.WriteLine(result[0] + " " + result[1]);
    }

}