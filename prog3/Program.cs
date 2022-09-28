void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0;i < array.Length-1;i++)
    {
         Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.Write("]");
}

Console.Write("Введите длинну массива :");

int elements = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elements];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,99);   
}

 PrintArray(array);

