int EnteringInt (string mess) { 
    Console.WriteLine (mess);
    bool flag = false;
    bool temp = false;
    int coor = 0;
    while (flag == false){
        temp = Int32.TryParse(Console.ReadLine(), out coor);
        if (temp == false) {
            Console.WriteLine($"Ошибка в введенных данных, попробуйте снова");
        }
        else  {
            flag = true; 
        }
    }
    return coor;
}

int Number = EnteringInt("Введите пятизначное число");
if (Number > 99999 || Number < 10000) {Console.WriteLine($"Ошибка в введенных данных, {Number} не пятизначное, TERMINATED");}
else {
int FirstChar = (Number / 10000);
int SecondChar = (Number / 1000) % 10;
int ThirdChar = (Number / 100) % 10;
int FourthChar = (Number / 10) % 10;
int FifthChar = (Number / 1) % 10;

if (FirstChar == FifthChar && SecondChar == FourthChar) {Console.WriteLine($"Число {Number} является палиндромом");}
else {
    Console.WriteLine($"Число {Number} обычное, ничего особенного");
    }
}