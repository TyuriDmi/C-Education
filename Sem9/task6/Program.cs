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

int SumFromNtoM (int n, int m) {
    if (m>n) return m+SumFromNtoM(n, m-1);
    else return n;
}

int result = SumFromNtoM(EnteringInt("Введите начало интервала"), EnteringInt("Введите конец интервала"));
Console.WriteLine($"Сумма числел в заданном интервале равна {result}");


