// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
int EnteringInt (string mess) { 
    Console.WriteLine (mess);
    bool flag = false;
    int Coor = 0;
    while (flag == false) {
        Coor = Convert.ToInt32 (Console.ReadLine());
        if (Coor<1 || Coor>4) {
            Console.WriteLine ("Введите корректное число");
    }
        else {
            flag = true;
        }
    }
    return Coor;
}
int Number = EnteringInt("Введите номер четверти");
if (Number == 1) {Console.WriteLine("Возможные координаты: X>0; Y>0");}
else if (Number == 2) {Console.WriteLine("Возможные координаты: X>0; Y<0");}
else if (Number == 3) {Console.WriteLine("Возможные координаты: X<0; Y<0");}
else if (Number == 4) {Console.WriteLine("Возможные координаты: X<0; Y>0");}

