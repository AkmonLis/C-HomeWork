Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

if (n>m)
    {
        NumbersInOrderForvard(m,n);
    }
else
    {
        NumbersInOrderBack(m,n);
    }


void NumbersInOrderForvard(int m, int n)
{
    if(m > n)
        {
        return;
        }
    Console.Write(m+ " ");
    NumbersInOrderForvard(m+1,n);
}

void NumbersInOrderBack(int m, int n)
{
    if(m < n)
        {
        return;
        }
    Console.Write(m+ " ");
    NumbersInOrderBack(m-1,n);
}