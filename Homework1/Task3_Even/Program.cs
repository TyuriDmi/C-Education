// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целое число");
//int temp = 0;
//while (temp == 0) {
int number = Convert.ToInt32(Console.ReadLine());
//if (int.TryParse(number, out) == 1) {
//    temp = 1;
//        }
//    else {
//        Console.WriteLine("Введите корректное число");
//    }
//}
if (number%2 == 0) {
    Console.WriteLine("Ваше число четное");
}
else {
    Console.WriteLine("Введенное число нечетное");
}

