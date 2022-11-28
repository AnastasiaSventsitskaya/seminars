// Написать программу, которая принимает на вход три числа и проверяет, иожет ли существовать треугольник с сторонами такой длины

Console.Write("Введите 1 число = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3 число = ");
int c = Convert.ToInt32(Console.ReadLine());

if (c <= a + b && a <= c + b && b <= a + c)
{
    Console.Write("Данные числа могут быть сторонами треугольника");
}
else 
{
    Console.Write("Данные числа не могут быть сторонами треугольника");
}