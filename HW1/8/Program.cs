Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int N = 2;
Console.Write("Чётные числа от 1 до N: ");
while (N <= number)
{
    if(N==number || N==(number-1))
    {
        Console.Write(N);
    }
    
    else Console.Write(N + ", ");
    N += 2;
}