// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
double[] AvrgColumn(double[,] mas)
{
    double[] result = new double[mas.GetLength(1)];
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            result[j] += mas[i, j];
        }
        result[j] = Math.Round(result[j] / mas.GetLength(0), 2);
    }
    return result;
}
System.Console.WriteLine($"Таблица средних арифметических столбцов массива: \n {String.Join("\t|", AvrgColumn(newArray))}");