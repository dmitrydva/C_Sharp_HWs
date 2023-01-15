Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); 

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString(); 
    return (start + ", " + PrintNumbers(start - 1, end));
}

Console.WriteLine(PrintNumbers(n, 1));
