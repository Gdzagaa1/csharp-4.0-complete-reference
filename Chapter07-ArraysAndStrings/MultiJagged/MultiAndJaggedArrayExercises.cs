namespace Chapter07_ArraysAndStrings.Multi_Jagged;

public class MultiAndJaggedArrayExercises
{
    
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