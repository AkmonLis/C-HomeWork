
Console.WriteLine("Введите число m");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int m = int.Parse(Console.ReadLine());

System.Console.WriteLine(AckermannFunction(m,n));

int AckermannFunction(int n, int m)
{
    if(n == 0)
    {
        return m+1;
    }
    else if (m == 0)
    {
        return AckermannFunction(n-1, 1);
    }                             
    else
    {
        return AckermannFunction(n-1, AckermannFunction(n, m-1));
    }           
}