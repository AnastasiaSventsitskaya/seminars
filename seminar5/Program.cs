// задайте массив на 12 элемнтов заполненный случайными числами из промежутка [-9;9] . Найдите сумма отридательных элементов и положительных


int [] array = new int [12];

int positivSum = 0;
int negativeSum = 0;

int [] GetArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
     {
        array[i] = new Random().Next(-9,10);
        if(array[i] > 0)
        {
            positivSum += array[i];
        }
        if(array[i] < 0)
        {
            negativeSum += array[i];
        }
     }
     return array;
}
GetArray(array);

Console.WriteLine(String.Join(" ", array));

Console.WriteLine(positivSum);
Console.WriteLine(negativeSum);
