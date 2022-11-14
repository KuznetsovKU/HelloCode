// Нахождение максимального значения из 9 переменных

int findMax (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 1, a2 = 34, a3 = 48;
int b1 = 14, b2 = 344, b3 = 8;
int c1 = 31, c2 = 54, c3 = 56;

int max = findMax(findMax(a1, a2, a3), findMax(b1, b2, b3), findMax(c1, c2, c3));
System.Console.WriteLine($"Максимальное число: {max}");
