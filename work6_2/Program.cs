// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1,
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Для нахождения точки пересечения двух прямых, заданных уравнениями,");
Console.WriteLine("введите переменную k1 для прямой заданной уравнением y = k1 * x + b1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите переменную b1 для прямой заданной уравнением y = k1 * x + b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите переменную k2 для прямой заданной уравнением y = k2 * x + b2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите переменную b2 для прямой заданной уравнением y = k2 * x + b2");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1==k2)
{
Console.WriteLine("прямые параллельны между собой (решения отсутствуют)");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1; 
    Console.WriteLine("точка пересечения прямых имеет координаты ("+x+ "; "+y+ ")");
}



// int y1 = k1 * x1 + b1;
// int y2 = k2 * x2 + b2;

// if (&& )
// {
//     Console.WriteLine("прямые совпадают (решение имеет бесконечно множество точек пересечения)");
// }
// else if ( )
// {
//     Console.WriteLine("прямые параллельны между собой (решения отсутствуют)");
// }
// else 
//{
//     Console.WriteLine("точка пересечения прямых имеет координаты ("+x+ "; "+y+ ")");
//}
