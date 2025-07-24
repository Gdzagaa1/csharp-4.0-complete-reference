namespace Chapter07_ArraysAndStrings.Multi_Jagged;

public class MultiAndJaggedArrayExercises
{
    
    /* Count Zero Neighbors
     * Description:
     * Given a (n x m) matrix of 0s and 1s, return a
     * new matrix of the same size where each cell contains
     * the number of adjacent (up, down, left, right) cells that are 0.
     */

    public static int[,] CountZeroNeighbors(int[,] matrix)
    {
        int originalRow = matrix.GetLength(0);
        int originalColumn = matrix.GetLength(1);
        int[,] newMatrix = new int[originalRow, originalColumn];
        
        for (int i = 0; i < originalRow; i++)
        {
            for (int j = 0; j < originalColumn; j++)
            {

                int newValue = 0;
                if (j - 1 >= 0)
                {
                    if (matrix[i, j - 1] == 0) newValue++;
                }

                if (j + 1 < originalColumn)
                {
                    if (matrix[i, j + 1] == 0) newValue++;
                }

                if (i - 1 >= 0)
                {
                    if (matrix[i - 1, j] == 0) newValue++;
                }

                if (i + 1 < originalRow)
                {
                    if (matrix[i + 1, j] == 0) newValue++;
                }

                newMatrix[i, j] = newValue;

            }
        }

        return newMatrix;
    }



    /**
     * Matrix Reshape.
     * My solution to problem: https://leetcode.com/problems/reshape-the-matrix/
     */
    public static int[][] MatrixReshape(int[][] mat, int r, int c) {
        if (mat.Length * mat[0].Length !=
            r * c) return mat;
    
        int[][] res = new int[r][];
        for (int i = 0; i < r; i++) {
            res[i] = new int[c];
        }
        int currCol = 0;
        int currRow = 0;

        for (int i = 0; i < mat.Length; i++) {
            for (int j = 0; j < mat[0].Length; j++) {
                res[currRow][currCol] = mat[i][j];
                currCol++;
            
                if (currCol == c) {
                    currCol = 0;
                    currRow++;
                }
            }
        }

        return res;
    }
    
    
}