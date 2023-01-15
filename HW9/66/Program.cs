Console.WriteLine("Введите m (m<=n):");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n (m<=n):");
int n = Convert.ToInt32(Console.ReadLine());

int PrintNumbers(int start, int end)
{
    if (start == end) return start;
    return (start + PrintNumbers(start + 1, end));
}

Console.WriteLine($"Cумма натуральных элементов в промежутке от m до n: {PrintNumbers(m, n)}");
