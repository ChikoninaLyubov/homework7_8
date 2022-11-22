// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
Console.Clear();
int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int k = 0; k < m; k++)
        {
            mas[i, k] = new Random().Next(0, 10);
        }
    }
    return mas;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            if (k != arr.GetLength(1) - 1) Console.Write($"\t{arr[i, k]} ");
            else if (i == arr.GetLength(0) - 1 && k == arr.GetLength(1) - 1) Console.WriteLine($"\t{arr[i, k]}");
            else if (k == arr.GetLength(1) - 1) Console.WriteLine($" \t{arr[i, k]}");
        }
    }
}
int[,] spiral(int n)
{
    int[,] mas = new int[n, n];
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int moves = n;
    for (int i = 0; i < mas.Length; i++)
    {
        mas[row, col] = i + 1;
        // цикл для изменнения направления и вычисления количества ходов
        if (--moves == 0)
        {              //задержка изменений по увеличению кругов 
            moves = n - (dirChanges / 2 - 1) - 2;
            // смена направления
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return mas;
}
System.Console.Write("Веедите число для спирали = ");
int n = Convert.ToInt32(Console.ReadLine());
PrintArray(spiral(n));