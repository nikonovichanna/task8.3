int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(1, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}


int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for ( int i = 0; i < matrixA.GetLength(0); i++)
    {
        for ( int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
            for ( int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}
int[,] matrixA = GetMatrix(2, 2);
PrintMatrix(matrixA);
System.Console.WriteLine();
int[,] matrixB = GetMatrix(2, 2);
PrintMatrix(matrixB);
System.Console.WriteLine();
PrintMatrix(MatrixMultiplication(matrixA, matrixB));