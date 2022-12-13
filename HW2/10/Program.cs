Console.Write("Введите положительное трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.Write("Вторая цифра числа: ");
    int N = (number / 10) % 10;
    Console.WriteLine(N);
}
else Console.WriteLine("Число не подходит -_- ");

