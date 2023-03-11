int Stepen(int a, int b) {
    if (b==1 || b==0) return a;
    else {
        return a*Stepen(a, b-1);
    }
}

Console.WriteLine($"{Stepen(3, 5)}");
