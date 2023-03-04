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

void FillArrayManual(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); i++)
        {
            array[i, j] = EnteringInt(
                $"Введите значение элемента массива c координатами {i} по горизонтали и {j} по вертикали"
            );
        }
    }
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Random.Shared.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.Write($"{array[i, array.GetLength(1)-1]}]");
        Console.WriteLine();
    }
}

void ScanElement (int[,] array) {
    int i = EnteringInt("Введите номер строки искомого элемента. Помни, счет начинается с 0");
    int j = EnteringInt("Введите номер столбца искомого элемента. Помни, счет начинается с 0");
    if (i<array.GetLength(0) && j<array.GetLength(1)) {
    Console.WriteLine($"Значение искомого элемента массива - {array[i,j]}");}
    else {
        Console.WriteLine($"Элемента с такими координатами на существует");
    }
}

int NumberOfLines = EnteringInt("Введите количество строк");
int NumberOfColumns = EnteringInt("Введите количество столбцов");
int[,] MyArray = new int[NumberOfLines, NumberOfColumns];
FillArrayRandom(MyArray);
ScanElement(MyArray);
Console.WriteLine();
PrintArray(MyArray);
