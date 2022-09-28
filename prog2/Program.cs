
Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int Summ(int Number)
{
    int result = 0;
    while(Number > 0 )
    {
        result += Number % 10;
        Number = Number /10;
    }
    return result;
}
int summ = Summ(Number);

Console.WriteLine(summ);
