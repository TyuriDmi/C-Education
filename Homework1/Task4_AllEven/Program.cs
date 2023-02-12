// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
Console.Write("Четные числа в диапазоне от 0 до ");
Console.Write(number);
Console.WriteLine(" следующие");
while (i<number) {
    //if (i%2 ==0) {
    Console.WriteLine(i);
    i = i + 2;
   // }
   // else {i++;}
}
