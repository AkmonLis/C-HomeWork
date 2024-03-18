System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int [size];

for (int i = 0; i < array.Length ; i++)
    {
        array[i]= new Random().Next(-100,101);
        Console.Write(array[i]+" ");
    }
Console.WriteLine("");
PrintArrayInReverse(size-1);


void PrintArrayInReverse (int size)
{
    if (size < 0)
    {
        return;
    }
    Console.Write(array[size]+ " ");
    PrintArrayInReverse(size-1);
}