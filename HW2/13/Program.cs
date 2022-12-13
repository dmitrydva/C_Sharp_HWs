Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    string str = number.ToString();
    Console.Write("Третья цифра числа: ");
    Console.WriteLine(str[2]);
}
else if (number < 0) Console.WriteLine("Число отрицательно");
else if (number < 100) Console.WriteLine("Третьей цифры нет");


