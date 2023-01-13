int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = GetMatrix(rows, columns, 0, 10);
PrintMatrix(result);

int[,] copy = result;
int temp;


for (int i = 0; i < copy.GetLength(0); i++)
{
    for (int k = 0; k < copy.GetLength(1) - 1; k++)
    {
        for (int j = 0; j < copy.GetLength(1) - 1; j++)
        {
            if (copy[i, j] < copy[i, j + 1])
            {
                temp = copy[i, j];
                copy[i, j] = copy[i, j + 1];
                copy[i, j + 1] = temp;
            }
        }
    }
}
Console.WriteLine("Упорядоченный массив: ");
PrintMatrix(copy);

