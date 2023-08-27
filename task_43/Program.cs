Console.Write("Введите коэффициент k1: ");
float k1 = float.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент b1: ");
float b1 = float.Parse(Console.ReadLine()!);

Console.Write("Введите коэффициент k2: ");
float k2 = float.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент b2: ");
float b2 = float.Parse(Console.ReadLine()!);

void point(float a1, float a2, float m1, float m2)
{
    if (a1 == a2) Console.WriteLine("Точка пересечения прямых отсутствует");
    else
    {
        float x = (m2 - m1) / (a1 - a2);
        float y = a1 * x + m1;
        Console.Write($"Точка пересечения двух прямых: ({x},{y}) ");
    }
}
point(k1, k2, b1, b2);
