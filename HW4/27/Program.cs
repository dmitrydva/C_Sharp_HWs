int GetSum(int a)
{
    string numba = a.ToString();
    int sum = 0;
    if (numba != null && a > 0)
    {
        int[] digits = new int[numba.Length];
        for (int i = 0; i < numba.Length; i++)
        {
            digits[i] = a % 10;
            a = a / 10;
            sum += digits[i];
        }
    }
    return sum;
}

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0) Console.WriteLine("Сумма цифр в числе: " + GetSum(N));
else Console.WriteLine("Число не подходит -_- ");

