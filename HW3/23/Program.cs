Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;

if (N > 0)
{
   while (i<N)
   {
    Console.Write(Math.Pow(i,3) + ", ");
    i++;
   }
   Console.Write(Math.Pow(i,3));
}
else Console.WriteLine("Число не подходит -_- ");
