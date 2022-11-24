//принимает число и выдает произведение от 1 до этого числа



Console.WriteLine("Write number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSumNum(num));

int GetSumNum(int res)
{
 int result = 1;
 int count = 1;

 while(res>=count)
 {
    result *= count;
    count++;
 }
 return result;
}

