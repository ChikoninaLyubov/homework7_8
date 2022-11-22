// /*Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка
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
int LowestLine(int[,] mas)
{
    int lowerIndex = 0;
    int[] sumInLine = new int[mas.GetLength(0)];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int k = 0; k < mas.GetLength(1); k++)
        {
            sumInLine[i] += mas[i, k];
        }
    }
    for (int i = 0; i < sumInLine.Length; i++)
    {
        for (int k = 0; k < sumInLine.Length; k++)
        {
            if (sumInLine[i] < sumInLine[k]) lowerIndex = i;
        }
    }
    return lowerIndex;
}
int[,] newArry = FillMas(5, 3);
PrintArray(newArry);
System.Console.WriteLine($"Самая маленькая суммма в массиве на {LowestLine(newArry)} строчке.");


