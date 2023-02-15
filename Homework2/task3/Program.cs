Console.WriteLine("Введите номер дня недели");
int DayNumber = Convert.ToInt32(Console.ReadLine());
if (DayNumber>7 || DayNumber<1) {
    Console.WriteLine ("нет такого дня недели");
}
else {
    if (DayNumber == 6 || DayNumber == 7){
        Console.WriteLine ("ВЫХОДНОЙ!");
    }
    else {
        Console.WriteLine ("Работать.....");
    }
}
