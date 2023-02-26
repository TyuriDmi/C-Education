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

int[] FillArrayInt(int Length, int Type)
{
    int[] array = new int[Length];
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
            array[i] = EnteringInt($"Введите {i+1} элемент нового массива");
        }
        return array;
    }
}

int SumElementsOfArray(int[] array, int Type) {
    int Result = 0;
    if(Type == 0){
    for(int i=0; i<array.Length; i++) {
        if (array[i]<0) {
            Result = Result + array[i];
        }
    }
    }
    else {
        for(int i=0; i<array.Length; i++) {
        if (array[i]>0) {
            Result = Result + array[i];
        }
    }
    }
    return Result;

    }

int Count = EnteringInt("Введите размер массива");
int[] Test = FillArrayInt(Count, 0);
Console.Write(string.Join(", ", Test));
Console.WriteLine();
int Posit = SumElementsOfArray(Test, 0);
int Neg = SumElementsOfArray(Test, 1);
Console.WriteLine($"Сумма отрицательных = {Neg}, а сумма положительных = {Posit}");



