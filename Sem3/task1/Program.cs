// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
int EnteringCoor (string mess) { 
    Console.WriteLine (mess);
    bool flag = false;
    int Coor = 0;
    while (flag == false) {
        Coor = Convert.ToInt32 (Console.ReadLine());
        if (Coor == 0) {
            Console.WriteLine ("Введите корректное число");
    }
        else {
            flag = true;
        }
    }
    return Coor;
}

int CoorX = EnteringCoor ("Координата по Х");
int CoorY = EnteringCoor ("Координата по Y");
if (CoorX>0 && CoorY>0) {
    Console.WriteLine ("Первая четверть");}
    else {
        if (CoorX>0 && CoorY<0) {
            Console.WriteLine("Вторая четверть");
        }
        else {
         if (CoorX<0 && CoorY<0)    {
            Console.WriteLine("Третья четверть");
         }
         else {
            Console.WriteLine("Четвертая четверть");
         }
    }
}     
