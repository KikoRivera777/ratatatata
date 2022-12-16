namespace Métodos;

class Program
{
    static void Main()
    {
        int m, n, resultado;

        m = LeerNumero();
        n = LeerNumero();

        resultado = Combinatorio(m, n);

        Console.WriteLine(resultado);
    }

    static int LeerNumero()
    {
        Console.WriteLine("Dame un número");
        return int.Parse(Console.ReadLine());
    }

    static int Combinatorio(int a, int b)
    {
        return Factorial(a) / Factorial(b) * (Factorial(b) * Factorial(a-b));
    }

    static int Factorial(int x)
    {
        int resultado = 1;

        for(int i = x; i > 1; i--)
        {
            resultado *= x; //resultado = resultado * x;
            
        }

        return resultado;
    }

    static void MostrarResultado(int resultado)
    {
        Console.WriteLine(resultado);
    }
}