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
Console.WriteLine();
PrintMatrix(result);

int[,] SumsInRows = new int[result.GetLength(0), 2];
int Sum;

for (int i = 0; i < result.GetLength(0); i++)
{
    Sum = 0;
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Sum += result[i, j];
    }
    SumsInRows[i, 0] = Sum;
    SumsInRows[i, 1] = i + 1;
}


for (int j = 0; j < SumsInRows.GetLength(0); j++)
{
    for (int i = 0; i < SumsInRows.GetLength(0) - 1; i++)
    {

        if (SumsInRows[i, 0] < SumsInRows[i + 1, 0])
        {
            //перестановка значений сумм
            int temp = SumsInRows[i, 0];
            SumsInRows[i, 0] = SumsInRows[i + 1, 0];
            SumsInRows[i + 1, 0] = temp;

            //перестановка индексов
            int temp2 = SumsInRows[i, 1];
            SumsInRows[i, 1] = SumsInRows[i + 1, 1];
            SumsInRows[i + 1, 1] = temp2;
        }
    }
}

Console.WriteLine();
//PrintMatrix(SumsInRows);
Console.WriteLine($"Номер строки с наименьшей суммой элементов (первая строка имеет номер 1): {SumsInRows[SumsInRows.GetLength(0) - 1, 1]}");





