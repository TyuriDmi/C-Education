// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int three = Convert.ToInt32(Console.ReadLine());
Console.Write("Последняя цифра числа: ");
int ost = three%10;
Console.WriteLine(ost);