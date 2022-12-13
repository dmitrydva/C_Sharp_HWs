Console.Write("Введите число, обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 6) Console.Write("День не является выходным");
else if (number > 5 && number < 8) Console.WriteLine("День является выходным");
else if (number > 7 || number < 1) Console.WriteLine("Число не обозначает день недели");


