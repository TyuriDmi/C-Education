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

void FillArrayManual(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = EnteringInt(
                    $"Введите значение элемента массива c координатами {i} по горизонтали, {j} по вертикали и {k} по глубине"
                );
            }
        }
    }
}

void PrintArrayLineByLine(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}[{i}, {j}, {k}]  ");
            }
            Console.WriteLine();
        }
    }
}

int NumberOfLines = EnteringInt("Введите количество строк массива");
int NumberOfColumns = EnteringInt("Введите количество столбцов массива");
int NumberOfTall = EnteringInt("Введите глубину массива");
int[,,] MyArray = new int[NumberOfLines, NumberOfColumns, NumberOfTall];
FillArrayManual(MyArray);
PrintArrayLineByLine(MyArray);
