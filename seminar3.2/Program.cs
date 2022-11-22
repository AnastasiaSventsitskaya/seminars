// напишите программу, которая принимает на вход число  и выдает таблицу квадратов чисел от 1 до этого числа


Console.WriteLine("Write number");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (var counter = 1; counter <= n; counter++) 
{
  Console.Write(counter * counter + " ");
}
