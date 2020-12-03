using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] result = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];

        for (int i = 0; i < result.GetLength(0); i++)
            for (int j = 0; j < result.GetLength(1); j++)
                result[i,j] = (int)Math.Pow(myMatrix[i,j], 2);

        return result;
    }
}
