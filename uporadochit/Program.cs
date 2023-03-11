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
void ToSortRowsMinToMax(int[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int temp=matr[0,0];
            if (matr[i,j] < temp)
            {
                matr[i, j-1] = matr[i, j];
                matr[i, j]=temp;
                temp=matr[i,j];            
            }          
        }  
        // int temp2=matr[0,0];
        // for (int j = 0; j < matr.GetLength(1); j++)
        // {
        //     if (matr[i,j] < temp2)
        //     {
        //         matr[i, j-1] = matr[i, j];
        //         matr[i, j]=temp2;
        //         temp2=matr[i,j];            
        //    }          
        // }  
    }
}
int[,] resultMatr = GetArray(1, 5, 0, 10);
PrintMatrix(resultMatr);
Console.WriteLine();
ToSortRowsMinToMax(resultMatr);
PrintMatrix(resultMatr);
