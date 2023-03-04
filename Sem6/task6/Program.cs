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

string temp = "";
bool flag = true;
int count = 0;
Console.WriteLine($"Вводите любые числа. Как надоест, пишите stop и я посчитаю количество положительных");
while(flag == true) {
    temp = Console.ReadLine();
    if(temp.ToLower() == "stop") {
    flag = false;
    break;}
    else if (Convert.ToDouble(temp)>0) {
        count++;
    }
}
Console.WriteLine($"Введено {count} положительных");