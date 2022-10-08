// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введи k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введи b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введи k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введи b2: ");
double b2 = double.Parse(Console.ReadLine());

//прямые пересекутся в той точке, в которой значения каждой из функций будут равны друг другу
//координата Х точки пересечения прямых будет равна

if(k1 == k2){
    Console.WriteLine("прямые не пересекаются");
}
else{
double x = (b2 - b1) / (k1 - k2);

//координата Y точки пересечения прямых вычислится через подстановку вычисленного Х

double y = k1*x + b1;

Console.WriteLine($"Координаты точки пересечения. X: {x}, Y: {y} ");
}

