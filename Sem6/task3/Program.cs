int EnteringInt(string MessageToUser)
{
    bool flag = false;
    bool temp = false;
    int Number = 0;
    while (flag == false)
    {
        Console.Write(MessageToUser);
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

string ConvertDecimalToDual(int Number) {
    string Dual = "";
    while (Number>0) {
        Dual = Convert.ToString(Number%2) + Dual;
        Number = Number/2;
    }
    return Dual;
}

int Decimal = EnteringInt("Ваше число: ");
string Result = ConvertDecimalToDual(Decimal);
Console.WriteLine($"{Decimal} в двоичном коде = {Result}");