void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j].ToString("00") + " ");
        }
        Console.WriteLine();
    }
}

void OneSpiral(ref int[,] matrix, ref int i, ref int j, int o, ref int value)
{
    do
    {
        if (matrix[i, j] == 0) matrix[i, j] = value;
        value++;
        j++;
    }
    while (j < matrix.GetLength(1) - 1 - o);

    do
    {
        if (matrix[i, j] == 0) matrix[i, j] = value;
        value++;
        i++;
    }
    while (i < matrix.GetLength(0) - 1 - o);

    do
    {
        if (matrix[i, j] == 0) matrix[i, j] = value;
        value++;
        j--;
    }
    while (j > 0 + o);

    do
    {
        if (matrix[i, j] == 0) matrix[i, j] = value;
        value++;
        i--;
    }
    while (i > 0 + 1 + o);
    return;
}

int[,] matrix = new int[4, 4];
int value = 1;
int i = 0;
int j = 0;

for (int o = 0; o < 2; o++) OneSpiral(ref matrix, ref i, ref j, o, ref value);
PrintMatrix(matrix);
