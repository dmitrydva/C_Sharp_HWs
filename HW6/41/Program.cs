
Console.WriteLine("Введите M чисел в формате 1, 2, 3");
string? line = Console.ReadLine();
if (!string.IsNullOrEmpty(line))
{
    string[] input = line.Split(',');
    int[] numbers = new int[input.Length];
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(input[i]);
        count += numbers[i] > 0 ? 1 : 0;
    }
    //Console.WriteLine(String.Join("; ", numbers));
    Console.WriteLine($"Чисел больше нуля: {count}");
}

