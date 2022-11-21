// принимает 2 чила и проверяет является ли одно квадратом другого.

int num1 = new Random().Next(10,100);
int num2 = new Random().Next(10,100);

Console.WriteLine(num1);
Console.WriteLine(num2);

if ((num1==num2*num2)||(num2==num1*num1))
  Console.WriteLine("yes");

else 
  Console.WriteLine("no");

