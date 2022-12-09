Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2, которое не равно числу 1: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Большее из двух чисел: ");

if (number1 > number2)
{
    Console.WriteLine(number1);
}
else Console.WriteLine(number2);