﻿Console.Clear();

//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());

int xa = 3;
int ya = 3;
int xb = 3;
int yb = 10;
int xc = 34;
int yc = 10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;
while (count < 1000)
{
    int what = new Random().Next(0, 3);//(0,3)0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
Console.SetCursorPosition(x,y);
Console.WriteLine("+");
count = count + 1;
}


Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

