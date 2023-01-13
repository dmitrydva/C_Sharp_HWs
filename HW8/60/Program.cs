int[] NumbersThatDoNotRepeat(int k, int minValue, int maxValue)
{
    int[] matrix = new int[k];
    matrix[0] = new Random().Next(minValue, maxValue + 1);
    for (int i = 1; i < k; i++)
    {
        int number;
        bool check = true;
        do
        {
            check = true;
            number = new Random().Next(minValue, maxValue + 1);
            for (int j = 0; j < i; j++)
            {
                if (matrix[j] == number) check = false;
            }
        } while (check == false);
        matrix[i] = number;
    }
    return matrix;
}


int[,,] GetMatrix(int m, int n, int l, int[] inputMatrix)
{
    int[,,] matrix = new int[m, n, l];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = inputMatrix[count];
                count++;
            }
        }
    }
    return matrix;
}


void PrintMatrix(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inputMatrix.GetLength(2); k++)
            {
                Console.WriteLine($"{inputMatrix[i, j, k]} {(i, j, k)}");
            }
        }
    }
}

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите глубину: ");
int depth = Convert.ToInt32(Console.ReadLine());

int Amount = rows * columns * depth;

int[,,] result = GetMatrix(rows, columns, depth, NumbersThatDoNotRepeat(Amount, 10, Amount * 10));
PrintMatrix(result);