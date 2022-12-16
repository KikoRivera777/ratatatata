namespace Recursividad;

class Program
{

    static void Main()
    {
        int fact = Factorial(5);
    }
    static int Factorial(int x)
    {
        int fact;

        if (x <= 1)
            fact = 1; 
        else
            fact = x * Factorial(x-1);

        return fact;
    }

}