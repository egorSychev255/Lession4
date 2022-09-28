Console.Write("Введите число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какую степень возвести число:  ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());


int DegreeNumber(int FirstNumber,int SecondNumber)
{
    int result = 1;
    for(int i = 0; i < SecondNumber; i++)
    {
     result = result * FirstNumber;
   
    }
    return result;
}

int result = DegreeNumber(FirstNumber,SecondNumber);
Console.WriteLine($"Число : {FirstNumber}\nВ степени {SecondNumber}\nРавно: {result}");
