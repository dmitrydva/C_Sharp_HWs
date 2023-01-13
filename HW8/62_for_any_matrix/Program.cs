void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (inputMatrix.GetLength(0) * inputMatrix.GetLength(1) < 10) Console.Write(inputMatrix[i, j].ToString("0") + " ");
            else if (inputMatrix.GetLength(0) * inputMatrix.GetLength(1) < 100) Console.Write(inputMatrix[i, j].ToString("00") + " ");
            else Console.Write(inputMatrix[i, j].ToString("000") + " ");
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

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
int value = 1;
int i = 0;
int j = 0;

for (int o = 0; o < Math.Min(rows, columns) / 2 + 1; o++) OneSpiral(ref matrix, ref i, ref j, o, ref value);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
