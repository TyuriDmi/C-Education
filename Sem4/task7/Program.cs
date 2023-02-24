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
int[] Numbers = new int[length];
string w = ", ";
for(int i=0; i<length; i++) {
    Numbers[i] = EnteringInt($"введите {i+1} элемент массива");
    }
Console.Write("[");
//for(int j=0; j<length; j++) {
//    Console.Write($"{Numbers[j]}, ");
 //   Console.Write(string.Join(w, Numbers[]));
//}
Console.Write(string.Join(w, Numbers));
Console.Write("]");