using System;

/// <summary>
/// Various vector calculations
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the dot product of 2 vectors
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if ((vector1.Length == 2 || vector1.Length == 3) && vector1.Length == vector2.Length)
        {
            for (int i = 0; i < vector1.Length; i++)
                vector1[i] *= vector2[i];

            double dp = 0;
            foreach (var v in vector1)
                dp += v;
            return dp;
        }

        return (-1);
    }
}
