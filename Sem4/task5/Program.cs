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

int Var = EnteringInt("введите число");
int Exl = EnteringInt("введите степень");
int Result = Var;
for (int i = 1; i<Exl; i++) {
    Result = Result * Var;
}
Console.WriteLine(Result);
