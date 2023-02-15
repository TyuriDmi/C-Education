int flag = 0;
int number = -1;
while (flag == 0) {
    Console.WriteLine("Введите трехзначное число");
    number = Convert.ToInt32 (Console.ReadLine());
    if (number/100 < 1 || number/100 > 9) 
    { 
        Console.WriteLine($"{number} не трехзначное!");
        }
    else flag = 1;
}
int SecondDigit = (number - (number % 10) - ((number /100) * 100))/10;
Console.WriteLine ($"вторая цифра равна {SecondDigit}");