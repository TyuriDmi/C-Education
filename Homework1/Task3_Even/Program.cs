// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целое число");
int temp = 0;
int numb = 0;
while (temp == 0) {
string number = Console.ReadLine();
bool read = Int32.TryParse(number, out numb);
if (read == true) {
    temp = 1;
        }
    else {
        Console.WriteLine("Введите корректное число");
    }
}
if (numb % 2 == 0) {
    Console.WriteLine("Ваше число четное");
}
else {
    Console.WriteLine("Введенное число нечетное");
}

