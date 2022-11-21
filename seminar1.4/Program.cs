// Напишите программу, оторая на входе принимает одно число, а на выхоже выдает все целые числа. 
// 4--> -4 -3 -2 -1 0 1 2 3 4

Console.WriteLine("Write number: ");
int num = Convert.ToInt32(Console.ReadLine());

int negNum = -num;
while(negNum<=num)
{
    Console.WriteLine(negNum);
    negNum++;
}