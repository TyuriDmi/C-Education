int EnteringInt(string MessageToUser)
{
    bool flag = false;
    bool temp = false;
    int Number = 0;
    while (flag == false)
    {
        Console.WriteLine(MessageToUser);
        temp = Int32.TryParse((Console.ReadLine()), out Number);
        if (temp == true && Number>0)
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

string[] FillArrayString(int Length)
{
    string[] array = new string[Length];
    {
        for (int i = 0; i < Length; i++)
        {
            Console.WriteLine($"Введите {i} элемент массива");
            array[i] = Console.ReadLine();
        }
        return array;
    }
}

string[] LessThenFour (string[] array) {
    int count = 0;
    for (int i =  0; i < array.Length; i++) {
        if (array[i].Length<4) count++;
    }
    string[] newArray = new string[count];
    int k = 0;
    for (int j =  0; j < newArray.Length; j++) {
        if (array[j].Length<4) {
            newArray[k] = array[j];
            k++;
        }
    }
    return newArray;
}

void PrintArray(string[] array) {
    Console.Write("[");
    for(int i=0; i<array.Length-1; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}



string[] myArray = FillArrayString(EnteringInt("Введите количество элементов массива"));
PrintArray(myArray);
string[] newArray = LessThenFour(myArray);
PrintArray(newArray);





