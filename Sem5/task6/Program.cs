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

int FindEven(int[] array) {
    int Result = 0;
        for(int i=0; i<array.Length; i++) {
        if (array[i] % 2 == 0) {
            Result +=1;
                    }
    }
    return Result;
}

int Count = EnteringInt("Введите размер массива");
int[] Test = FillArrayInt(Count, 0);
Console.Write(string.Join(", ", Test));
Console.WriteLine();
Console.Write($"В массиве {FindEven(Test)} четных числел");