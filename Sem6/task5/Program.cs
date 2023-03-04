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

int[] FillArrayInt(int Length, int Type)
{
    
    int[] array = new int[Length];
    if (Type == 0)
    {
        int LeftBorder = EnteringInt("введите левую границу случайного диапазона ");
        int RightBorder = EnteringInt("введите правую границу случайного диапазона ");
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

int [] CopyOfArray (int[] array ) {
    int[] NewArray = new int[array.Length];
    for (int i = 0; i<array.Length; i++) {
        NewArray[i] = array[i];
    }
    return NewArray;
}

int [] array = FillArrayInt(9, 0);

Console.WriteLine(string.Join(" ", CopyOfArray(array)));
array[3] = 500;
Console.WriteLine(string.Join(" ", array));
