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

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Random.Shared.Next(-9, 10);
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

int[,] MultiplMatrix(int[,] firstArray, int[,] secArray) {
    int[,] results = new int[firstArray.GetLength(0),firstArray.GetLength(1)];
    if (firstArray.GetLength(0) == secArray.GetLength(0) && firstArray.GetLength(1) == secArray.GetLength(1)) {
        for(int i=0; i<results.GetLength(0); i++) {
            for (int j=0; j<results.GetLength(1); j++) {
                results[i,j] = firstArray[i,j]*secArray[i,j];
            }
        }
        return results;
    }
    else throw new Exception("Матрицы нельзя перемножить");
    return results;
}

int NumberOfLinesFirst = EnteringInt("Введите количество строк первого массива");
int NumberOfColumnsFirst = EnteringInt("Введите количество столбцов первого массива");
int[,] MyArrayFirst = new int[NumberOfLinesFirst, NumberOfColumnsFirst];
FillArrayRandom(MyArrayFirst);
int NumberOfLinesSecond = EnteringInt("Введите количество строк второго массива");
int NumberOfColumnsSecond = EnteringInt("Введите количество столбцов второго массива");
int[,] MyArraySecond = new int[NumberOfLinesSecond, NumberOfColumnsSecond];
FillArrayRandom(MyArraySecond);
PrintArray(MyArrayFirst);
Console.WriteLine("----------------------------");
PrintArray(MyArraySecond);
Console.WriteLine("Произведение матриц:");
PrintArray(MultiplMatrix(MyArrayFirst, MyArraySecond));
