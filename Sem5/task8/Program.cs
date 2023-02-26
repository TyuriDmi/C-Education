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

double[] FillArrayInt(int Length, int Type)
{
    
    double[] array = new double[Length];
    if (Type == 0)
    {
        int LeftBorder = EnteringInt("введите левую границу случайного диапазона");
        int RightBorder = EnteringInt("введите правую границу случайного диапазона");
        for (int i = 0; i < Length; i++)
        {
            array[i] = Random.Shared.Next(LeftBorder, RightBorder);
        }
        return array;
    }
    else
    {
        for (int i = 0; i < Length; i++)
        {
            array[i] = EnteringDouble($"Введите {i+1} элемент нового массива");
        }
        return array;
    }
}

void PrintArray(double[] array) {
    Console.Write("[");
    for(int i=0; i<array.Length-1; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}

(double, double) MinMaxOfArray(double[] array) {
    double Min = array[0];
    double Max = array[0];
    for(int i=1; i<array.Length; i++){
        if(array[i]>Max) {Max = array[i];}
        else if(array[i]<Min) {Min = array[i];}
    }
    return (Min, Max);
}

int Count = EnteringInt("Введите размер массива");
double[] Test = FillArrayInt(Count, 1);
double Result = 0;
(double Min, double Max) = MinMaxOfArray(Test);
Result = Max-Min;
PrintArray(Test);
Console.WriteLine($"Разница между максимальным и минимальными элементами массива равна {Result}");
