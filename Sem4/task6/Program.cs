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

int Var = EnteringInt("Введите целое число");
int i;
int Result = 0;
for (i = 1; Var>0; i++) {
    Result = Result + Var%10;
    Var = Var / 10;
}
Console.WriteLine(Result);
