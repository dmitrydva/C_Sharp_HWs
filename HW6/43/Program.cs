Console.WriteLine("Введите натуральное N: ");
int N = Convert.ToInt32(Console.ReadLine());

string to2(int n)
{
    string res="";
    while (N != 1)
    {
        if (N % 2 == 0)
        {
            res = "0"+res;
        }
        else
        {
            res = "1"+res;
            N += -1;
        }
        N = N / 2;
    }
    res = "1"+res;
    return res;
}

if (N>0) Console.WriteLine($"Число в двоичной системе счисления:{to2(N)}");
else Console.WriteLine("N не натуральное");