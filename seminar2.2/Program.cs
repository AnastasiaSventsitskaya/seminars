// вывести число и проверить кратно ли оно 23 и 7 одновременно

int num = new Random().Next(10,100);
Console.WriteLine(num);

if ((num%7==0) && (num%23==0))
{
    Console.WriteLine("number"+ num + "yes 23 and yes 7");
}

else
{
    Console.WriteLine("no");
}