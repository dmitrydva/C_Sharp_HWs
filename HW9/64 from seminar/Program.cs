Console.WriteLine("Введите m (m<=n):");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n (m<=n):");
int n = Convert.ToInt32(Console.ReadLine());


string PrintNumbers(int start, int end)
{
    //if (start==0) return PrintNumbers(start + 1, end);
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start + 1, end));
}


Console.WriteLine($"Все числа в промежутке от m до n: {PrintNumbers(m, n)}");