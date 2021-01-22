using System;

/// <summary>
/// Contains various matrix calculations
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices together
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return (new double[,] {{-1}});

        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        /* Personal reference
          matrix1.GetLength(0) -> matrix1 Rows
          matrix1.GetLength(1) -> matrix1 Columns
          matrix2.GetLength(0) -> matrix2 Rows
          matrix2.GetLength(1) -> matrix2 Columns
          */
        for (int i = 0; i < matrix1.GetLength(0); i++) // Loop through matrix1 rows
        {
            for (int j = 0; j < matrix2.GetLength(1); i++) // Loop through matrix2 columns
            {
                for (int k = 0; k < matrix1.GetLength(1); k++) // Loop through matrix1 columns
                {
                    result[i, j] += (matrix1[i, k] * matrix2[k, j]);  // hurts my brain
                }
            }
        }
        return (result);
    }
}
