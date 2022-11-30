// Задать двумерный массив. Найти элементы, у которых оба индекса четные , и замените эти элементы на их квадраты


Console.WriteLine("write number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(2,14);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine("_____________");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            matrix[i,j] *= matrix[i,j];
        }
         Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
