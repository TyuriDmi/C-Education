// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите три числа");
double FirstNumber = Convert.ToDouble(Console.ReadLine());
double SecondNumber = Convert.ToDouble(Console.ReadLine());
double ThirdNumber = Convert.ToDouble(Console.ReadLine());
double max = FirstNumber;
if (SecondNumber>max) {
    max = SecondNumber;}
else {
     if (ThirdNumber>max) {
        max = ThirdNumber;
        }
   } 
Console.Write("Максимальное из трех введенных чисел - ");
Console.WriteLine(max);