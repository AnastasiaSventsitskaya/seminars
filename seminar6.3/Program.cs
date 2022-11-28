// Вывести первые Н чисел Фибонначи. Первое 0 второе 1


Console.WriteLine("Write the number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int firstEl = 0;
int secondEl = 1;

for (int i = 0; i <= n; i++)
{
    int nextEl = firstEl + secondEl;

    Console.Write(firstEl + " , ");

    firstEl = secondEl;
    secondEl = nextEl;
}