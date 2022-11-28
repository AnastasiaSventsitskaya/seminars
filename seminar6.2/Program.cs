// перевернуть одномерный массив

int[] array = new int [6];

int [] GetArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = new Random ().Next(1,10);  
    }
    return array;
}

Console.WriteLine(String.Join(" ", GetArray(array)));

int [] ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
    return array;
}




Console.WriteLine(String.Join(" ",  ChangeArray(array)));

