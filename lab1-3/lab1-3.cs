using System;

float a = 1000;
double b = 0.0001;

double c = (((Math.Pow(a + b, 2)) - (Math.Pow(a, 2) + (2 * a * b))) / Math.Pow(b, 2));

Console.WriteLine(c);