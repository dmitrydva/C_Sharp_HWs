
Console.WriteLine("Введите b1, k1, b2, k2: ");
string? line = Console.ReadLine();
if (!string.IsNullOrEmpty(line))
{
    string[] input = line.Split(',');
    if (input.Length == 4)
    {
        double[] numbers = new double[input.Length];
       
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(input[i]);
        }
        
        double X0 = (numbers[2]-numbers[0])/(numbers[1]-numbers[3]);
        double Y0 = numbers[1]*X0+numbers[0];
        //Console.WriteLine(String.Join("; ", numbers));
        Console.WriteLine($"Координата x: {X0}");
        Console.WriteLine($"Координата y: {Y0}");
    }
    else Console.WriteLine("Некорректный ввод");
}


