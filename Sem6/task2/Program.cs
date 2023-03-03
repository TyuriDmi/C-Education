double EnteringDouble(string MessageToUser)
{
    bool flag = false;
    bool temp = false;
    double Number = 0;
    while (flag == false)
    {
        Console.WriteLine(MessageToUser);
        temp = double.TryParse((Console.ReadLine()), out Number);
        if (temp == true && Number>0)
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

double OneCoast = EnteringDouble("введите длину первого отрезка");
double TwoCoast = EnteringDouble("введите длину  второго отрезка");
double ThreeCoast = EnteringDouble("введите длину третьего отрезка");

if (OneCoast<TwoCoast+ThreeCoast && TwoCoast<OneCoast+ThreeCoast && ThreeCoast<OneCoast+TwoCoast) {Console.WriteLine("Из таких отрезков можно построить треугольник");}
else {Console.WriteLine("из таких отрезков невозможно построить треугольник");}

