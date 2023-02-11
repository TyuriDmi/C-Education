// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число 1");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число 2");
double number2 = Convert.ToDouble(Console.ReadLine());
if ((number2*number2) == number1)
{
    Console.Write(number2);
    Console.Write(" является квадратом ");
    Console.Write(number1);
}
else 
{
    Console.Write(number2);
    Console.Write(" не является квадратом ");
    Console.Write(number1);    
}