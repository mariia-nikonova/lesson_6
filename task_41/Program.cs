Console.Write("Введите числа через пробел: ");
int[] number = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count(int[] number)
{
    int n = number.Length;
    int c = 0;
    for (int i = 0; i < n; i++)
    {
        if (number[i] > 0) c = c + 1;
    }
    return c;
}

int k = count(number);
Console.WriteLine($"Количество положительных элементов в массиве: {k}");




