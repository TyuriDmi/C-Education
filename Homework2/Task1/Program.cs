﻿bool flag = false;
int number = -1;
while (flag == false) {
    Console.WriteLine("Введите трехзначное число");
    number = Convert.ToInt32 (Console.ReadLine());
    if (number/100 < 1 || number/100 > 9) 
    { 
        Console.WriteLine($"{number} не трехзначное!");
        }
    else flag = true;
}
int SecondDigit = (number - (number % 10) - ((number /100) * 100))/10;
Console.WriteLine ($"вторая цифра равна {SecondDigit}");