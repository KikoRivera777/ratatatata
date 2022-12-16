int num;

Console.WriteLine("Introduzca un número entero");
num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    if (i%2 == 0 && i%3 == 0)
    {
        Console.WriteLine(i);
    }
}