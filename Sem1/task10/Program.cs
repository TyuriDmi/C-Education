// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
double count = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Целые числа: ");
for (double i = (-count); i<=count; i++)
{
Console.WriteLine(i);
}

