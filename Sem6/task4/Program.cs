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

int[] Fibonacci (int Number) {
    int[] Result = new int[Number];
    Result[0] = 0;
    Result[1] = 1;
        for(int i=2; i<Number; i++) {
        Result[i] = Result[i-1] + Result[i-2];
    }
    return Result;
}

int Number = EnteringInt("Введите количество требуемых чисел последовательности Фибоначчи: ");
int[] FibonacciNumbers = Fibonacci(Number);
Console.Write(string.Join(" ", FibonacciNumbers));

