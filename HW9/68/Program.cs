Console.WriteLine("Введите m (m>=0):");
int m = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите n (n>=0):");
int n = Convert.ToInt32(Console.ReadLine()); 

int Ack(int m, int n)
{
        if (m == 0) return n + 1;
        if (n == 0) return Ack(m - 1, 1);
        return Ack(m - 1, Ack(m, n - 1));
}

Console.WriteLine($"A(m,n) = {Ack(m,n)}");