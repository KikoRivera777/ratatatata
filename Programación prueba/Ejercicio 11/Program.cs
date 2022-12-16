int num;

Console.WriteLine("Introduzca un número entero");
num = Convert.ToInt32(Console.ReadLine());

for (int i =2; i <= num; i++)
{
    bool isPrime = true;

    for (int j=2; j <= i/2 && isPrime; j++)
    {
        if (i % j == 0) isPrime = false;
    }

    if (isPrime) Console.WriteLine(i);
} 