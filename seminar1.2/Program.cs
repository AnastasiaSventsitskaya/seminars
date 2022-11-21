//  Задача ввести два числа и проверить является ли первое квадратом второго.

Console.WriteLine("write number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num == num2*num2)
{
   Console.WriteLine("Number" + num + "Является квадратом числа" + num2);
}
else
{
   Console.WriteLine("Number" + num + "Не является квадратом числа" + num2);
}