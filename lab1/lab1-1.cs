using System;

int n = 0;
int m = 0;

// №1
Console.WriteLine(++n * ++m);

// №2
Console.WriteLine(m++ < n);

// №3
Console.WriteLine(n++ > m);


// №4
Console.Write("Введите число X: ");
string numForX = Console.ReadLine();
int x = Convert.ToInt32(numForX);
double resultX = 0;
resultX = x + (1 / (Math.Pow(x, 2) - x)) - 2;
Console.WriteLine(resultX);