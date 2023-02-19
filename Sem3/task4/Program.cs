int EnteringInt (string mess) { 
    Console.WriteLine (mess);
    bool flag = false;
    bool temp = false;
    int coor = 0;
    while (flag == false){
        temp = Int32.TryParse(Console.ReadLine(), out coor);
        if (temp == false){
            Console.WriteLine($"Ошибка в введенных данных");
        }
        else  {
            flag = true; 
        }
    }
    return coor;
}

int Key = EnteringInt ("Введите число");
double NewKey = Convert.ToDouble(Key);
for (int i=1; i<NewKey; i++) {
    Console.WriteLine($"{i} в квадрате равно {Math.Pow(i,2)}");
}
