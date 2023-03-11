// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Матрицу P можно умножить на матрицу K только в том случае, 
// если число столбцов матрицы P равняется числу строк матрицы K. 
// Матрицы, для которых данное условие не выполняется, умножать нельзя. 
//матрицы можно умножить только если А[i,j] B[m,n] если j==m !
//произведение матрицы А[i,j]*B[m,n]=C[i,n] нужно умножить элементы строки А на ссответсвующие эл столбца В 
//и их сложить
Console.WriteLine("Программа для умножения матриц");
/// <summary>
/// Создание матрицы с заднными параметрами
/// </summary>
/// <param name="rows">кол-во строк</param>
/// <param name="cols">кол-во столбцов</param>
/// <param name="minValue">мин значение</param>
/// <param name="maxValue">макс значение</param>
/// <returns></returns>
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
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
/// Печать(вывод на экран) матрицы
/// </summary>
/// <param name="matrix">печатуемая матрица</param>
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
Console.WriteLine("введите количество строк и столбцов через кнопку ENTER для матрицы А");//ввод исходных данных для матриц
int rowsA = Convert.ToInt32(Console.ReadLine());
int colsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("задайте минимальное и максимальное значение в вашей матрице через кнопку ENTER");
int minRandomValueA = Convert.ToInt32(Console.ReadLine());
int maxRandomValueA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество строк и столбцов через кнопку ENTER для матрицы В");
int rowsB = Convert.ToInt32(Console.ReadLine());
int colsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("задайте минимальное и максимальное значение в вашей матрице через кнопку ENTER");
int minRandomValueB = Convert.ToInt32(Console.ReadLine());
int maxRandomValueB = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = GetMatrix(rowsA, colsA, minRandomValueA, maxRandomValueA);
int[,] matrixB = GetMatrix(rowsB, colsB, minRandomValueB, maxRandomValueB);
/// <summary>
/// Поиск произведения матриц
/// </summary>
/// <param name="matrA">умножаемая матрица</param>
/// <param name="matrB">матрица-множитель</param>
/// <returns></returns>
int[,] GetMultiplicationMatrix(int[,] matrA, int[,] matrB)
{
    int[,] multiMatrix = new int[matrA.GetLength(0), matrB.GetLength(1)];
    int rowsMulti = matrA.GetLength(0);
    int colsMulti = matrB.GetLength(1);

    for (int i = 0; i < rowsMulti; i++)
    {
        for (int j = 0; j < colsMulti; j++)
        {
            for (int n = 0; n < matrA.GetLength(1); n++)
            {
                multiMatrix[i, j] += matrA[i, n] * matrB[n, j];
            }
        }
    }
    return multiMatrix;
}
if (colsA != rowsB)//проверка на умножаемость
{
    Console.WriteLine($"произведение матриц невозможно");
    return;
}
int[,] multiplicatedMatrix = GetMultiplicationMatrix(matrixA, matrixB);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
PrintMatrix(multiplicatedMatrix);
