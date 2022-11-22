//Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
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
int[,] MatrixMultiply(int[,] mas1, int[,] mas2)
{
    int[,] result = new int[mas1.GetLength(0), mas2.GetLength(1)];
    if (mas1.GetLength(1) != mas2.GetLength(0) && mas1.GetLength(0) != mas2.GetLength(1)) return null;
    if (mas1.GetLength(1) != mas2.GetLength(0)) return MatrixMultiply(mas2, mas1);
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < mas1.GetLength(1); k++)
            {
                result[i, j] += mas1[i, k] * mas2[k, j];
            }
        }
    }
    return result;
}
int[,] newArry1 = FillMas(2, 3);
int[,] newArry2 = FillMas(3, 4);
System.Console.WriteLine("Первая матрица");
PrintArray(newArry1);
System.Console.WriteLine("Вторая матрица");
PrintArray(newArry2);
System.Console.WriteLine("Произведение матриц :");
try
{
    PrintArray(MatrixMultiply(newArry1, newArry2));
}
catch
{
    System.Console.WriteLine("Матрицы не совместимы");
}