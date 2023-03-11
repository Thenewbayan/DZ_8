// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
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
int [,] GetUlitka(int side)
{
    int [,] ulitkaMatrix=new int[side, side];
    int i=0;
    int j=0;
    while (ulitkaMatrix[i,j]==0)
    {
        ulitkaMatrix[i,j]+=1;
        if (j<side)
        {
            j++;
        }
        else if (i<side)
        {
            i++;
        }
        else if(j>=0)
        {
            j--;
        }
        else 
        {
            i--;
        }    
    }
    
}