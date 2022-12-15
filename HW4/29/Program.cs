int[] digits = new int[8];

for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Введите {i} элемент массива: ");
    digits[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Ваш массив: ");

for (int i = 0; i < 7; i++)
{
    Console.Write(digits[i] + ", ");
}

Console.Write(digits[7]);









