// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
Console.Clear();

object[] SearchElementByIndex(double[,] mas, int[] srch)
{
    object[] result = new object[1];
    if (srch[0] - 1 > mas.GetLength(0) || srch[1] - 1 > mas.GetLength(1)) { result[0] = "Такого числа в массиве нет"; }
    else result[0] = mas[srch[0] - 1, srch[1] - 1];
    return result;
}
System.Console.WriteLine("Введите индекс через пробел");
int[] searchReq = Console.ReadLine().Split().Select(int.Parse).ToArray();
System.Console.WriteLine(SearchElementByIndex(newArray, searchReq)[0]);
object[] SearchElementByValue(double[,] mas, int srch)
{
    object[] result = new object[3];
    result[1] = null;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            result[2] = 0;
            if (Convert.ToInt32(mas[i, j]) == srch) { result[0] = i; result[1] = j; return result; }
            else result[2] = -1;
        }
    }
    if (Convert.ToInt32(result[2]) == -1) result[0] = ("отсутствует в массиве");
    return result;
}
System.Console.Write("Введите искомое число = ");
int srch = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Индекс числа {srch} в массиве {SearchElementByValue(newArray, srch)[0]},{SearchElementByValue(newArray, srch)[1]}");