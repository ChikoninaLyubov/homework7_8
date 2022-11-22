// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
//двузначных чисел. Напишите программу, которая будет построчно
//выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
Console.Clear();
void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            for (int j = 0; j < arr.GetLength(2); j++)
            {
                if (j != arr.GetLength(2) - 1) Console.Write($"\t{arr[i, k, j]}({i},{k},{j})");
                else if (k == arr.GetLength(1) - 1 && j == arr.GetLength(2) - 1) Console.WriteLine($"\t{arr[i, k, j]}({i},{k},{j})");
                else if (j == arr.GetLength(2) - 1) Console.WriteLine($"\t{arr[i, k, j]}({i},{k},{j})");
            }
        }
    }
}
int[,,] ThirdDimMass(int n)
{
    int ignoreIndex = 0;
    int[,,] mas = new int[n, n, n];
    int[] ignoreList = new int[mas.Length];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(2); k++)
            {
                mas[i, j, k] = GetUniqValue(ignoreList, ignoreIndex);
            }
        }
    }
    return mas;
}
int GetUniqValue(int[] mas, int ignoreIndex)
{
    int newValue = new Random().Next(10, 100);
    while (Array.IndexOf(mas, newValue) != -1) newValue = new Random().Next(10, 100);
    mas[ignoreIndex] = newValue;
    ignoreIndex++;
    return newValue;
}
System.Console.Write("Веедите размерность массива = ");
int n = Convert.ToInt32(Console.ReadLine());
PrintArray(ThirdDimMass(n));