// написать программу, которая принимает на вход координаты точки X u Y, причем X != Y!= выдает номер четверти плоскости, в которой находится точка.


Console.WriteLine("write X: ");
int x = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("write Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
   Console.WriteLine("1");
}
if(x < 0 && y > 0)
{
   Console.WriteLine("2");
}
if(x < 0 && y < 0)
{
   Console.WriteLine("3");
}
if(x > 0 && y < 0)
{
   Console.WriteLine("4");
}