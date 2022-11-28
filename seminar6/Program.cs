// Напишите программу , которая делает десятичное число в двоичное

Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

string result = "";
while (n > 0)
{
    result = n % 2 + result;
    n /= 2;
}

Console.Write(result);