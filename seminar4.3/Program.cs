// программа , которая выводит массив элементов, заполненный нуями и единицами в случайном порядке

int [] GetArray(int size)
{
    int[] array1 = new int[size];
    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(0,2);
    }
    return array1;
}
int[] array = GetArray(8);

Console.Write(String.Join(",",array));