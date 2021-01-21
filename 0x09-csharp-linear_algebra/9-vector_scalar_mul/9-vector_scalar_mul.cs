using System;

/// <summary>
/// Various vector calculations
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates a scalar multiplication on a vector
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2 || vector.Length == 3)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] *= scalar;
            return vector;
        }

        return (new double[] {-1});
    }
}
