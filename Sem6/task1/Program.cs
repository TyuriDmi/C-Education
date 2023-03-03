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

void PrintArray(int[] array) {
    Console.Write("[");
    for(int i=0; i<array.Length-1; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}


int count = EnteringInt("Введите размер массива");
int[] MyArray = FillArrayInt(count, 0);
PrintArray(MyArray);
for(int i = 0; i<(count/2); i++) {
    int temp = MyArray[i];
    MyArray[i] = MyArray[count-1-i];
    MyArray[count-1-i] = temp;
}
PrintArray(MyArray);

