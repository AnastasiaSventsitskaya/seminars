// принимает на вход число А и выдает сумму чисел от 1 до А

Console.WriteLine("Write number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSumNum(num));

int GetSumNum(int res)
{
 int sum = 0;
 int count = 0;

 while(count <res)
 {
    count++;
    sum += count;
 }
 return sum;
}

