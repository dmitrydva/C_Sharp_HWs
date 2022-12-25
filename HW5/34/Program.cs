int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int Size = Convert.ToInt32(Console.ReadLine());

int[] resultArray = GetArray(Size, 100, 999);
Console.WriteLine(String.Join("; ", resultArray));
int result = 0;
for (int i = 0; i < resultArray.Length; i++) result += resultArray[i] % 2 == 0 ? 1 : 0;
Console.WriteLine($"Количество чётных чисел: {result}");