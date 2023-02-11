// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 4");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 5");
int num5 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2>max)
{
    max=num2;
};
if (num3>max)
{
    max=num3;
};
if (num4>max)
{
    max=num4;
};
if (num5>max)
{
    max=num5;
};
Console.Write("Максимальное числр равно ");
Console.WriteLine(max);