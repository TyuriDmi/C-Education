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

int length = Math.Abs(EnteringInt("введите количество элементов массива"));
int[] bools = new int[length];
for(int i=0; i<length; i++) {
    bools[i] = Random.Shared.Next(0,2);
    Console.Write($"{bools[i]}   " );
}

