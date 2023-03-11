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
            array[i, j] = Random.Shared.Next(-99, 100);
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

int[,] DeleteLineAndColumn(int[,] array, int [] position) {
    int [,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    int i1=0;
    int j1=0;
    for (int i = 0; i < array.GetLength(0);) {
        j1=0;
        if(i == position[0]) {
            i++;
        }
        else {
            for (int j = 0; j<array.GetLength(1);) {
                if(j == position[1]) {
                    j++;
                }
                else {
                    newArray[i1, j1] = array[i,j];
                    j++;
                    j1=j1+1;
                }
            }
            i++;
            i1=i1+1;
        }
    }
    return newArray;
}

int [] PositionOfMinimum (int[,] array) {
    int min = array[0,0];
    int [] position = new int[2];
        for (int i=0; i<array.GetLength(0); i++) {
        for (int j=0; j<array.GetLength(1); j++) {
            if (array[i,j]<min) {
                min=array[i,j];
                position[0]=i;
                position[1]=j;
            }
        }
    }
    return position;
}
   

int NumberOfLines = EnteringInt("Введите количество строк");
int NumberOfColumns = EnteringInt("Введите количество столбцов");
int[,] MyArray = new int[NumberOfLines, NumberOfColumns];
FillArrayRandom(MyArray);
PrintArray(MyArray);
Console.WriteLine("----------------------");

//int[,] newArray = DeleteLineAndColumn(MyArray, 3, 3);
PrintArray(DeleteLineAndColumn(MyArray, PositionOfMinimum(MyArray)));
//PrintArray(newArray);

