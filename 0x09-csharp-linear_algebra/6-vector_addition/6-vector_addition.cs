using System;

/// <summary>
/// Various vector calculations
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the sum of a given vector, 2D or 3D
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if ((vector1.Length == 2 || vector1.Length == 3) && vector1.Length == vector2.Length)
        {
            for (int i = 0; i < vector1.Length; i++)
                vector1[i] += vector2[i];
 
            return (vector1);
        }

        return (new double[] {-1});
    }
}
