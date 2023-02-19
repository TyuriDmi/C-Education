double EnteringCoor (string mess) { 
    Console.WriteLine (mess);
    double Coor = Convert.ToDouble(Console.ReadLine());
    return Coor;
}
Double FirstX = EnteringCoor("Введите Х для 1-й точки");
Double FirstY = EnteringCoor("Введите Y для 1-й точки");
Double FirstZ = EnteringCoor("Введите Z для 1-й точки");
Double SecondX = EnteringCoor("Введите Х для 2-й точки");
Double SecondY = EnteringCoor("Введите Y для 2-й точки");
Double SecondZ = EnteringCoor("Введите Z для 2-й точки");

double distance = Math.Sqrt (Math.Pow((FirstX - SecondX),2) + Math.Pow((FirstY - SecondY),2) + Math.Pow((FirstZ - SecondZ),2));
Console.WriteLine($"Расстояние между точками 1 и 2 равно {distance:f2}");
