// // написать программу, которая принимает на вход координаты точки X u Y, причем X != Y!= выдает номер четверти плоскости, в которой находится точка.


// Console.WriteLine("write X: ");
// int x = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("write Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x > 0 && y > 0)
// {
//    Console.WriteLine("1");
// }
// if(x < 0 && y > 0)
// {
//    Console.WriteLine("2");
// }
// if(x < 0 && y < 0)
// {
//    Console.WriteLine("3");
// }
// if(x > 0 && y < 0)
// {
//    Console.WriteLine("4");
// }



//Напишите программу, которая по заданному номеру четверти, покажет диапазон возможных точек xy



Console.WriteLine("четверть");
int num = Convert.ToInt32(Console.ReadLine());


if(num == 1)
{
   Console.WriteLine("x>0 y>0");
}
else if(num == 2)
{
   Console.WriteLine("x<0 y>0");
}
else if(num == 3)
{
   Console.WriteLine("x<0 y<0");
}
else if(num == 4)
{
   Console.WriteLine("x>0 y<0");
}
else 
{
    Console.WriteLine("False");
}