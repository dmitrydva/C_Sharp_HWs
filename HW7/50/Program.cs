double GetRandomDoubleNumber(double minimum, double maximum)
{
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}

double[,] GetMatrix(int m, int n, double minValue, double maxValue)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(GetRandomDoubleNumber(minValue, maxValue), 2); ;
        }
    }
    return matrix;
}


void PrintMatrix(double[,] inputMatrix)
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

double[,] result = GetMatrix(rows, columns, -10, 10);
PrintMatrix(result);

Console.WriteLine("Введите позиции элемента через запятую (первая строка и столбец имеют индексы 0):");

string? line = Console.ReadLine();
if (!string.IsNullOrEmpty(line))
{
    string[] input = line.Split(',');
    int[] coordinates = new int[input.Length];

    for (int i = 0; i < coordinates.Length; i++)
    {
        coordinates[i] = int.Parse(input[i]);
    }

    if (coordinates.Length > 2 || coordinates[0] < 0 || coordinates[1] < 0) Console.WriteLine("Некорректный ввод");
    else if (coordinates[0] > rows - 1 || coordinates[1] > columns - 1) Console.WriteLine("Такого числа в массиве нет");
    else Console.WriteLine($"Ваш элемент: {result[coordinates[0], coordinates[1]]}");
}


