double GetRandomNumber(double minimum, double maximum)
{
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(GetRandomNumber(minValue, maxValue), 2);
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int Size = Convert.ToInt32(Console.ReadLine());

double[] resultArray = GetArray(Size, -99, 99);
Console.WriteLine(String.Join("; ", resultArray));

double min = resultArray[0];
double max = resultArray[0];
double diff = 0;

for (int i = 0; i < resultArray.Length; i++)
{
    if (resultArray[i]<min) min = resultArray[i];
    if (resultArray[i]>max) max = resultArray[i];
}

diff=Math.Round(max-min,2);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {diff}");