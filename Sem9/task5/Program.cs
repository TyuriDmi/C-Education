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

void OneToN (int n) {
    if (n>0) {
        Console.WriteLine (n);
        OneToN(n-1);
    }
    else return;
}


OneToN(EnteringInt("Введите число"));
