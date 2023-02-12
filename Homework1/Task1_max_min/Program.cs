// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
double FirstNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double SecondNumber = Convert.ToDouble(Console.ReadLine());
if (FirstNumber == SecondNumber) {
    Console.WriteLine("Числа равны");
}
else {
    if (FirstNumber > SecondNumber) {
    Console.Write("Максимальное = ");
    Console.WriteLine(FirstNumber);
    Console.Write("Минимальное = ");
    Console.WriteLine(SecondNumber);
    }
    else {
    Console.Write("Максимальное = ");
    Console.WriteLine(SecondNumber);
    Console.Write("Минимальное = ");
    Console.WriteLine(FirstNumber);
    }
}  