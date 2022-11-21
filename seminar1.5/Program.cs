// Напишите задачу, которая на вход прирнимает трехзначное число и на выходе показывает последнюю цифру этого числа.
//456->6

Console.WriteLine("Write number: ");
int num=Convert.ToInt32(Console.ReadLine());

int result=num%10;
Console.WriteLine (result);