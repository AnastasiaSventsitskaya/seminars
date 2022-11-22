// напишите программу, которая при вводе точек , находит расстояние между ними в 2д пространстве

Console.WriteLine("write X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("write Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("write Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));

Console.WriteLine(result);