/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double[,] coefficient = new double[2, 2];
double[] PointOfIntersection = new double[2];

void UserValues()
{
    for (int i = 0; i < coefficient.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < coefficient.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            coefficient[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Definition(double[,] coefficient)
{
    PointOfIntersection[0] = (coefficient[1, 1] - coefficient[0, 1]) / (coefficient[0, 0] - coefficient[1, 0]);
    PointOfIntersection[1] = PointOfIntersection[0] * coefficient[0, 0] + coefficient[0, 1];
    return PointOfIntersection;
}

void OutputResult(double[,] coefficient)
{
    if (coefficient[0, 0] == coefficient[1, 0] && coefficient[0, 1] == coefficient[1, 1])
    {
        Console.Write($"Прямые совпадают");
    }
    else if (coefficient[0, 0] == coefficient[1, 0] && coefficient[0, 1] != coefficient[1, 1])
    {
        Console.Write($"Прямые параллельны");
    }
    else
    {
        Definition(coefficient);
        Console.Write($"Точка пересечения прямых: ({PointOfIntersection[0]}, {PointOfIntersection[1]})");
    }
}

UserValues();
OutputResult(coefficient);