Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 10;
int Result = -1;
if ((number / 100) == 0) {
    Console.WriteLine($"Число {number} не имеет третьей цифры");
}
else {
    while (Result != 0) {
        Result = number / i;
        i = i * 10;
    };
    Console.WriteLine (i);
   int ThirdDigit = number % (i/1000);
   ThirdDigit = ThirdDigit / (i/10000);
   Console.WriteLine($"Третья слева цифра числа {number} - {ThirdDigit}");
}