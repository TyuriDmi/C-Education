int EnteringInt(string MessageToUser)
{
    bool flag = false;
    bool temp = false;
    int Number = 0;
    while (flag == false)
    {
        Console.WriteLine(MessageToUser);
        temp = Int32.TryParse((Console.ReadLine()), out Number);
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

void NToM (int n, int m) {
    if (m>=n) {
        NToM(n, m-1);
        Console.WriteLine (m);
    }
    else return;
}


NToM(EnteringInt("Введите начало интервала"), EnteringInt("Введите конец интервала"));
