double EnteringDouble(string MessageToUser)
{
    bool flag = false;
    bool temp = false;
    double Number = 0;
    while (flag == false)
    {
        Console.WriteLine(MessageToUser);
        temp = double.TryParse((Console.ReadLine()), out Number);
        if (temp == true)
        {
            flag = true;
        }
        else
        {
            Console.WriteLine("Ошибка ввода");
        }
    }
    return Number;
}

double k1 = EnteringDouble("Введите коэффициент для первой прямой");
double b1 = EnteringDouble("Введите размер сдвига для первой прямой");
double k2 = EnteringDouble("Введите коэффициент для второй прямой");
double b2 = EnteringDouble("Введите размер сдвига для второй прямой");
double CoordX = 0;
double CoordY = 0;



if(k1 == k2) {
    if(b1 == b2) {
        Console.WriteLine("прямые накладываются");
    }
    else {
        Console.WriteLine("прямые параллельны");
    }
}
else {
    CoordX = (b2-b1)/(k1-k2);
    CoordY = k1*CoordX+b1;
    Console.WriteLine ($"Координаты пересесечния прямых: X={CoordX}, Y={CoordY}");
}




