// Задать двумерный массив m на n , каждый элемент массива задается по формуле Amn=m+n 


Console.WriteLine("write number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i + j;
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}