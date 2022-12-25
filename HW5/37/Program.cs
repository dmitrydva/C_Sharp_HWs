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

int[] resultArray = GetArray(Size, -99, 99);
Console.WriteLine(String.Join("; ", resultArray));

int[] secondarray = new int[resultArray.Length % 2 == 0 ? resultArray.Length / 2 : resultArray.Length / 2 + 1];
for (int i = 0; i < secondarray.Length; i++) secondarray[i] = i != resultArray.Length - 1 - i ? resultArray[i] * resultArray[resultArray.Length - 1 - i] : resultArray[i];
Console.WriteLine(String.Join("; ", secondarray));
