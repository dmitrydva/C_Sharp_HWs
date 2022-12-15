int ToThePower(int a, int b)
{
    int result = 1;
    if (a > 0 && b > 0)
    {
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }
    }
    return result;
}

Console.Write("Введите натуральное число X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x >= 1 && y >= 1) Console.WriteLine("X^Y: " + ToThePower(x, y));
else Console.WriteLine("Числа не подходят -_- ");

