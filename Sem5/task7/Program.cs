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

int SummOddPosition (int[] array) {
    int Result = 0;
    int i=1;
    while(i<array.Length) {
        Result = Result + array[i];
        i = i + 2;
    }
    return Result;
}

int Count = EnteringInt("Введите размер массива");
int[] Test = FillArrayInt(Count, 0);
Console.Write(string.Join(", ", Test));
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях равна {SummOddPosition(Test)}");
