// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/// <summary>
/// Генератор случайных неповторяющихся чисел в массиив
/// </summary>
/// <param name="min">мин значение</param>
/// <param name="max">макс значение</param>
/// <returns></returns>
int[] GetRandomNonRepitNumber(int min, int max)//создадим массив случайных неповтяряющихся чисел в диапазоне
{
    int quantity = max - min;
    int[] randomArray = new int[quantity];
    randomArray[0] = min;
    for (int i = 1; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(min, max + 1);
        for (int j = 0; j < i; j++)
        {
            while (randomArray[i] == randomArray[j])
            {
                randomArray[i] = new Random().Next(min, max + 1);
                j = 0;
            }
        }
    }
    return randomArray;
}
int[] randNumbersArray = GetRandomNonRepitNumber(10, 99);//хрянятся неповторяющиеся случайные числа
/// <summary>
/// заполнение 3д массива числами из массива случ неповтор чисел
/// </summary>
/// <param name="rows">строки</param>
/// <param name="cols">столбцы</param>
/// <param name="deep">глубина</param>
/// <returns></returns>
int[,,] Get3DArray(int rows, int cols, int deep)
{
    int[,,] array3D = new int[rows, cols, deep];
    int m = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = randNumbersArray[m];
                m++;
            }
        }
    }
    return array3D;
}
/// <summary>
/// Вывод на жкран 3д массив
/// </summary>
/// <param name="array">требуемый массив</param>
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k});  ");
            }
            Console.WriteLine();
        }

    }

}
Console.WriteLine("Поэлементно выведем 3д массив на экран");
Console.WriteLine("Укажите через ENTER количество строк, столбцов и глубину массива");
int rows =Convert.ToInt32(Console.ReadLine());
int cols= Convert.ToInt32(Console.ReadLine());
int deep = Convert.ToInt32(Console.ReadLine());
int[,,] resultArray = Get3DArray(rows, cols, deep);
Console.WriteLine($" Вот так ваш масисв выгдядит поэлемнетно:");
Print3DArray(resultArray);