int EnteringInt(string MessageToUser) {
bool flag = false;
bool temp = false;
int Number = 0;
while (flag == false) {
    Console.WriteLine(MessageToUser);
        temp = Int32.TryParse((Console.ReadLine()), out Number);
    if (temp == true) {
        flag = true;
    }
    else {
        Console.WriteLine("Ошибка ввода");
    }
}
return Number;
}

int result = 1;
int count = EnteringInt("ВВедите целое число");
int i = 1;
while (i<=count) {
    result = result * i;
    i++;
}
Console.WriteLine(result);
