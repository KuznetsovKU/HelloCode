/*
#region 2-мерный массив тип: строки

string[,] table = new string[2, 5];
// table[0,0]   table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]   table[1,1]  table[1,2]  table[1,3]  table[1,4]


table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        System.Console.WriteLine($"-{table[rows, columns]}-");
    }
    System.Console.WriteLine();
}

#endregion
*/

/*
#region 2-мерный массив тип: числа (целые)
    

void Print_Matrix(int[,] input_matrix)
{
    for (int row = 0; row < input_matrix.GetLength(0); row++)
    {
        for (int column = 0; column < input_matrix.GetLength(1); column++)
        {
            System.Console.Write($"{input_matrix[row, column]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void Fill_Matrix(int[,] input_matrix)
{
    for (int row = 0; row < input_matrix.GetLength(0); row++)
    {
        for (int column = 0; column < input_matrix.GetLength(1); column++)
        {
            input_matrix[row, column] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
Print_Matrix(matrix);
Fill_Matrix(matrix);
Print_Matrix(matrix);

#endregion
*/

/*
#region Закрашивание замкнутого изображения (рекурсия)

int[,] pic = new int[,]
{
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void Print_Image(int[,] input_image)
{
    for (int row = 0; row < input_image.GetLength(0); row++)
    {
        for (int column = 0; column < input_image.GetLength(1); column++)
        {
            //System.Console.Write($"{input_image[row, column]} ");
            if (input_image[row, column] == 0) System.Console.Write($" ");
            else System.Console.Write($"+");
        }
        System.Console.WriteLine();
    }
}

void Fill_Image(int row, int column)
{
    if (pic[row, column] == 0)
    {
        pic[row, column] = 1;
        Fill_Image(row-1, column);
        Fill_Image(row, column-1);
        Fill_Image(row+1, column);
        Fill_Image(row, column+1);
    }
}

Print_Image(pic);
Fill_Image(13, 13);
Print_Image(pic);

#endregion
*/

/*
#region Нахождение факториала (рекурсия)

double Factorial(int num)
{
    // 1! = 1
    // 0! = 1
    if (num == 1) return 1;
    else return num * Factorial(num - 1);
} 
System.Console.WriteLine(Factorial(5));

for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}

#endregion
*/

#region Последовательность Фибоначчи (рекурсия)

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int num)
{
    if (num == 1 || num == 2) return 1;
    else return Fibonacci(num - 1) + Fibonacci(num - 2);
}

for (int i = 1; i < 50; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

#endregion


