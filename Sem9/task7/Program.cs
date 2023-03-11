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

//функция ack(n, m)
//  / если n = 0
//   /  вернуть m + 1
//   иначе, если m = 0
//     вернуть ack (n - 1, 1)
//   еще
//     вернуть ack(n - 1, ack (n, m - 1))

int Akkerman (int one, int second) {
    if (one == 0) return second+1;
    else {
        if (second == 0) {
            return Akkerman(one-1, 1);
        }
        else return Akkerman(one-1, Akkerman(one, second-1));
    }
    
 }

int result = Akkerman(EnteringInt("Введите первый аргумент функции Аккермана"), EnteringInt("Введите второй аргумент функции Аккермана"));
Console.WriteLine($"Значение функции для заданных параметров равно {result}");

