// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
Console.WriteLine("Создадим программу для нахождения строки с наименьшей суммой значений");
/// <summary>
/// метод создания матрицы с заданными количеством строк, столбцов, мин и макс значениями
/// </summary>
/// <param name="rows">количество строк</param>
/// <param name="cols">количество столбцов</param>
/// <param name="minValue">мин значение для матрицы</param>
/// <param name="maxValue">ьакс значение для матрицы</param>
/// <returns>Возврат заданной матрицы</returns>
int[,] GetArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}
/// <summary>
/// Вывод на экран матрицы
/// </summary>
/// <param name="matrix">указываем матрицу которую необходимо вывести на экран</param>
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
/// <summary>
/// Нахождение строки с наименьшей суммой всех элементов
/// </summary>
/// <param name="matrix">исходная матрица</param>
void MinRowsValue(int[,] matrix)
{
    int minSummRow = int.MaxValue;//мин значение
    int tempSumm = 0;//переменная для перезаписи
    int indexRow = 0;//индекс переменный
    int minIndexRow = 0;//индекс минимальный
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempSumm += matrix[i, j];
            indexRow = i;
        }
        if (tempSumm < minSummRow)
        {
            minSummRow = tempSumm;
            minIndexRow = indexRow;
            tempSumm = 0;
        }
    }
    Console.WriteLine($"Минимальная сумма всех элементов равна {minSummRow} и находится в строке с индексом {minIndexRow}");
}
Console.WriteLine("введите количество строк и столбцов через кнопку ENTER");
int rows=Convert.ToInt32(Console.ReadLine());
int cols=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("задайте минимальное и максимальное значение в вашей матрице через кнопку ENTER");
int minRandomValue=Convert.ToInt32(Console.ReadLine());
int maxRandomValue=Convert.ToInt32(Console.ReadLine());
int[,] resultMatrix = GetArray(rows, cols, minRandomValue, maxRandomValue);
PrintMatrix(resultMatrix);
MinRowsValue(resultMatrix);