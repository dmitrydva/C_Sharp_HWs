Console.Write("Введите положительное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int n5 = number % 10;
    int n4 = (number / 10) % 10;
    int n2 = (number / 1000) % 10;
    int n1 = number / 10000;

    if (n1 == n5 && n2 == n4) Console.Write("Число является палиндромом");
    else Console.Write("Число не является палиндромом");
}
else Console.WriteLine("Число не подходит -_- ");

