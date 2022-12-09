Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( (Math.Abs(number) % 2) == 1 )
{
    Console.WriteLine("Число нечётное");
}
else Console.WriteLine("Число чётное");