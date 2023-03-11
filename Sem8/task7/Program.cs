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

int[] SumOfLines(int[,] array) {
    int[] results = new int[array.GetLength(0)];
     for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1) - 1; j++){
            results[i] = results[i]+array[i,j];
        }
     }
    return results;
}

int Min (int[] results) {
    int min = results[0];
    int indexMin = 0;
    for (int i=0; i<results.Length; i++) {
        if (results[i]<min) {
            min = results[i];
            indexMin = i;
        }
    }
    return indexMin;
}

int NumberOfLines = EnteringInt("Введите количество строк");
int NumberOfColumns = EnteringInt("Введите количество столбцов");
int[,] MyArray = new int[NumberOfLines, NumberOfColumns];
FillArrayRandom(MyArray);
PrintArray(MyArray);
Console.WriteLine($"Строка с минимальной суммой имеет индекс {Min(SumOfLines(MyArray))}");