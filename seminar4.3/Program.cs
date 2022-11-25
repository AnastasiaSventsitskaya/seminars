// программа , которая выводит массив элементов, заполненный нуями и единицами в случайном порядке

// int [] GetArray(int size)
// {
//     int[] array1 = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array1[i] = new Random().Next(0,2);
//     }
//     return array1;
// }
// int[] array = GetArray(8);

// Console.Write(String.Join(",",array));

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
}
int[] array = new int[8];
FillArray(array);

Console.WriteLine(String.Join(",",array));

/*
    int, double, char, float, byte, bool - значимые типы, то есть если копирубтся иои куда-то передаются, то копируется полностью их значение
    array(int[], float[] и т д), string - ссылочные типы, то есть копируется не полностью, а только ссылка на него
*/ 