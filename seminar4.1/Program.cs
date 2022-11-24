// принимает на вход число и выдает кол-во цифр в числе

Console.WriteLine("Write number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Колличество цифр" + GetCountNum(num));

int GetCountNum(int res)
{
    int count = 0;
    while(res>0)
    {
        count++;
        res/=10;
    }
    return count;
}



