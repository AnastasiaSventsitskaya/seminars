// программа принимает два числа и выводить является ли второе кратным первому. если не кратно, то выводим остаток от деления


int num1 = new Random().Next(10,100);
int num2 = new Random().Next(10,100);

Console.WriteLine(num1);
Console.WriteLine(num2);

if (num1%num2==0)
{
    Console.WriteLine("Число"+num1+ "кратное числу" + num2);
}
else 
{
    Console.WriteLine("Остаток от деления"+num1%num2);
}