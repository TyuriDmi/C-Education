int SummOfDigits (int number) {
    int sum = number%10;
    if (number<10) {
        sum = number%10;
        }
    else {
       sum = sum + SummOfDigits(number/10);
    }
    return sum;
}

Console.WriteLine($"{SummOfDigits(900)}");

int SummOfDigits2 (int number) {
    int sum = number%10;
    if (number>10) {
        sum = sum+SummOfDigits2(number/10);
    }
    return sum;
}

Console.WriteLine($"{SummOfDigits2(45012)}");
