int max_temp;

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2, которое не равно числу 1: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3, которое не равно числам 1 и 2: ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Большее из трёх чисел: ");

if (number1 > number2)
{
    max_temp=number1;
}
else max_temp=number2;

if (number3 > max_temp)
{
    max_temp=number3;
}

Console.WriteLine(max_temp);