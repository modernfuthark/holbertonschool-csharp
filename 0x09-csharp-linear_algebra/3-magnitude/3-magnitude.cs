using System;

/// <summary>
/// Various vector calculations
/// </summary>
class VectorMath
{
	/// <summary>
	/// Calculates length of a given vector, 2D or 3D
	/// </summary>
	public static double Magnitude(double[] vector)
	{
		if (vector.Length != 2 && vector.Length != 3)
			return (-1);

        double sum = 0;

        foreach (var v in vector)
            sum += (Math.Pow(v, 2));

        return Math.Round(Math.Sqrt(sum), 2);
	}
}
