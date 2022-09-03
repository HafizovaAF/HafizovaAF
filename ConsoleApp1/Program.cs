using System;


int x, y;
Console.WriteLine("Введите x");
 x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
y = Convert.ToInt32(Console.ReadLine());

int z = x;
y = x;
x = y;

Console.WriteLine($"x=(x),y=(y)");
