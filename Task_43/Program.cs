//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine($"\nПрограмма для нахождения точки пересечения двух прямых\n" +
"заданных уравнениями y = k1 * x + b1, y = k2 * x + b2\n");

Console.WriteLine("\nВведите значение переменной k1\n");
double b1 = Double.Parse(Console.ReadLine());

Console.WriteLine("\nВведите значение переменной b1\n");
double k1 = Double.Parse(Console.ReadLine());

Console.WriteLine("\nВведите значение переменной k2\n");
double b2 = Double.Parse(Console.ReadLine());

Console.WriteLine("\nВведите значение переменной b2\n");
double k2 = Double.Parse(Console.ReadLine());

double Xcoordinate = ( b2 - b1 ) / ( k1 - k2 );
double Ycoordinate = ( k1 * Xcoordinate + b1 );

Console.WriteLine($"Координаты точки пересечения двух прямых = [{Xcoordinate};{Ycoordinate}]");
