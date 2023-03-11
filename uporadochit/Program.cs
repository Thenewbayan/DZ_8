// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/// <summary>
/// метод создания матрицы с заданными количеством строк, столбцов, мин и макс значениями
/// </summary>
/// <param name="rows">количество строк</param>
/// <param name="cols">количество столбцов</param>
/// <param name="minValue">мин значение для матрицы</param>
/// <param name="maxValue">макс значение для матрицы</param>
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
/// Сортировка значений матрицы в каждой строке по возрастанию
/// </summary>
/// <param name="matr">исх матрица</param>
void ToSortRowsMinToMax(int[,] matr)
{
    int tepm;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k=j+1; k<matr.GetLength(1);k++)
            {
                if (matr[i,j]>matr[i,k])
                {
                    tepm=matr[i,j];
                    matr[i,j]=matr[i,k];
                    matr[i,k]=tepm;
                }
            }
        }
    }   
}
/// <summary>
/// Сортировка значений матрицы в каждой строке по убыванию
/// </summary>
/// <param name="matr">исх матрица</param>
void ToSortRowsMaxToMin(int[,] matr)
{
    int tepm;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k=j+1; k<matr.GetLength(1);k++)
            {
                if (matr[i,j]<matr[i,k])
                {
                    tepm=matr[i,j];
                    matr[i,j]=matr[i,k];
                    matr[i,k]=tepm;
                }
            }
        }
    }   
}
Console.WriteLine("Зададим матрицу и отсутрируем значения в каждой из строк по возрастанию и убыванию");
Console.WriteLine("Задайте количество строк и столбцов через  ENTER");
int userRows=Convert.ToInt32(Console.ReadLine());
int userCols=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте мин и макс значения для записи в строки и сортировки через  ENTER");
int minUserValue=Convert.ToInt32(Console.ReadLine());
int maxUserValue=Convert.ToInt32(Console.ReadLine());
int[,] resultMatr = GetArray(userRows, userCols, minUserValue, maxUserValue);
Console.WriteLine();
Console.WriteLine("Исходная матрица выглядит вот так:");
PrintMatrix(resultMatr);
Console.WriteLine();
Console.WriteLine("Отсортированная по возрастанию матрица выглядит вот так:");
ToSortRowsMinToMax(resultMatr);
PrintMatrix(resultMatr);
Console.WriteLine();
Console.WriteLine("Отсортированная по убыванию матрица выглядит вот так:");
ToSortRowsMaxToMin(resultMatr);
PrintMatrix(resultMatr);
