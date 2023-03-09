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
            array[i, j] = Random.Shared.Next(-100, 100);
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

void ReplaceFirstWithLastLines(int[,] array) {
    for(int i=0; i<array.GetLength(1); i++){
        int temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = temp;
    }
}

int NumberOfLines = EnteringInt("Введите количество строк");
int NumberOfColumns = EnteringInt("Введите количество столбцов");
int[,] MyArray = new int[NumberOfLines, NumberOfColumns];
FillArrayRandom(MyArray);
PrintArray(MyArray);
Console.WriteLine("------------");
ReplaceFirstWithLastLines(MyArray);
PrintArray(MyArray);
