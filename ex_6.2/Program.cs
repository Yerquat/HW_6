// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем. //&& ((y = k1 * x + b1) || (y = k2 * x + b2)));
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void InterSectionPoint(double k1, double b1, double k2, double b2)

{
    if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"координаты точки пересечния:  " + "(" + (x) + " ; " + (y) + ")");
    }

}


double EnterData(string text)
{
    Console.Write(text);
    double number = double.Parse(Console.ReadLine());
    return number;
}
double k1 = EnterData($"Введитe значение k1:  ");
double b1 = EnterData($"Введитe значение b1:  ");
double k2 = EnterData($"Введитe значение k2:  ");
double b2 = EnterData($"Введитe значение b2:  ");

InterSectionPoint(k1, b1, k2, b2);

