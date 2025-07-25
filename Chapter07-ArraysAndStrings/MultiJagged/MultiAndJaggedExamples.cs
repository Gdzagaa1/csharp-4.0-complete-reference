namespace Chapter07_ArraysAndStrings.Multi_Jagged;

/**
 * Book examples of Multidimensional/Jagged/Implicitly typed arrays
 * from Chapter 7 for testing/learning (Some of them may be changed).
 */

public class MultiAndJaggedExamples
{
    
// Demonstrate an implicitly typed jagged array.
    public static void ImplicitJagged() {
        var jagged = new[] {
            new[] { 1, 2, 3, 4 },
            new[] { 9, 8, 7 },
            new[] { 11, 12, 13, 14, 15 }
        };
        for(int j = 0; j < jagged.Length; j++) {
            for(int i = 0; i < jagged[j].Length; i++)
                Console.Write(jagged[j][i] + " ");
            Console.WriteLine();
        }
    }

    
    
    // Demonstrate jagged arrays.
    public static void Jagged() {
        int[][] jagged = new int[3][];
        jagged[0] = new int[4];
        jagged[1] = new int[3];
        jagged[2] = new int[5];
        int i;
        // Store values in first array.
        for(i = 0; i < 4; i++)
            jagged[0][i] = i;
        // Store values in second array.
        for (i = 0; i < 3; i++)
            jagged[1][i] = i;
        // Store values in third array.
        for(i = 0; i < 5; i++)
            jagged[2][i] = i;
        // Display values in first array.
        for(i = 0; i < 4; i++)
            Console.Write(jagged[0][i] + " ");
        Console.WriteLine();
        // Display values in second array.
        for(i = 0; i < 3; i++)
            Console.Write(jagged[1][i] + " ");
        Console.WriteLine(); // Display values in third array.
        for(i = 0; i < 5; i++)
            Console.Write(jagged[2][i] + " ");
        Console.WriteLine();
    }
    
    // Demonstrate a two-dimensional array.
    // It loads a two-dimensional array with the numbers 1
    // through 12 and then displays the contents of the array.
    public static void TwoD() {
        int t, i;
        int[,] table = new int[3, 4];
        for(t = 0; t < 3; ++t) {
            for(i = 0; i < 4; ++i) {
                table[t, i] = (t * 4) + i + 1;
                Console.Write(table[t,i] + " ");
            }
            Console.WriteLine();
        }
    }
    
    // Sum the values on a diagonal of a 3x3x3 matrix.
    public static void ThreeDMatrix() {
        int[,,] m = new int[3, 3, 3];
        int sum = 0;
        int n = 1;
        for(int x = 0; x < 3; x++)
            for(int y = 0; y < 3; y++)
                for(int z = 0; z < 3; z++) 
                    m[x, y, z] = n++;
        sum = m[0, 0, 0] + m[1, 1, 1] + m[2, 2, 2];
        Console.WriteLine("Sum of first diagonal: " + sum);
    }
    
    // Initialize a two-dimensional array.
    // the following program initializes an array called sqrs with the numbers 1
    // through 10 and their squares.
    public static void Squares()
    {
        int[,] sqrs =
        {
            { 1, 1 },
            { 2, 4 },
            { 3, 9 },
            { 4, 16 },
            { 5, 25 },
            { 6, 36 },
            { 7, 49 },
            { 8, 64 },
            { 9, 81 },
            { 10, 100 }
        };
        int i, j;
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 2; j++)
                Console.Write(sqrs[i, j] + " ");
            Console.WriteLine();
        }

    }

}