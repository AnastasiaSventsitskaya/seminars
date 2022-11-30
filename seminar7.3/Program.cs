// Задать двумерный массив. Найти сумму элементов, находящихся на главной диагонали (с индексами (0,0) (1,1) и т.д)


Console.WriteLine("write number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int [,] matrix = new int [rows,columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,12);
        Console.Write(matrix[i,j]+" ");
     
      if (i == j)
        {
            sum += matrix[i,j];
        }
    }
    Console.WriteLine();
}
Console.Write("Сумма элементов главной диагонали : " + sum);