Console.Clear();
int xa = 1;
int ya = 1;
int xb = 100;
int yb = 1;
int xc = 50;
int yc = 20;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("8");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("8");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("8");
int x = xa, y = ya;
int count = 0;
while(count<10000)
{
    int bust = new Random().Next(0,3);
    if (bust == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    };
    if (bust == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    };
    if (bust == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    };
    Console.SetCursorPosition(x, y);
    Console.WriteLine("8");
    count++;
};
Console.SetCursorPosition(0, (yc+1));