using System;
using Chapter07_ArraysAndStrings;
using Chapter07_ArraysAndStrings.Multi_Jagged;

class Program
{
    static void Main(string[] args)
    {
        TestArrays();
        TestMultiJagged();
    }

    static void TestMultiJagged()
    {
        Console.WriteLine("--TwoD--");
        MultiAndJaggedExamples.TwoD();
        
        Console.WriteLine("--ThreeDMatrix--");
        MultiAndJaggedExamples.ThreeDMatrix();
        
        Console.WriteLine("--Squares--");
        MultiAndJaggedExamples.Squares();
        
        Console.WriteLine("--Count Zero Neighbors--");
        int[,] matrix =
        {
            { 1, 0, 1 },
            { 0, 1, 0 }
        };
        int[,] resultMatrix = MultiAndJaggedArrayExercises.CountZeroNeighbors(matrix);
        PrintMatrix(resultMatrix);
    }
    
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
    
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }



    static void TestArrays()
    {
        int[] nums = {2, 7, 11, 15};
        int target = 9;
        int[] result = ArrayExercise.TwoSum(nums, target);
        Console.WriteLine("--TwoSum--");
        Console.WriteLine(result[0] + " " + result[1]);
    }

}