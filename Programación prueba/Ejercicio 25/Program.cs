namespace Ejercicio_25
{
    class Program
    {
        static void Main()
        {
            int m, n, resta;
            m = PedirNumero();
            n = PedirNumero();
            resta = Operacion(m, n);
            Resultado(m, n, resta);

        }
        static int PedirNumero()
        {
            Console.WriteLine("Introduce un número");
            return int.Parse(Console.ReadLine());
        }
        static int Factorial(int x)
        {
            int fact = 1;
            for (int i = 2; i <= x; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static int Operacion(int m, int n)
        {
            return Factorial(m) - Factorial(n);
        }
        static void Resultado(int m, int n, int resta)
        {
            Console.WriteLine("Para m = {0} y n = {1} el resultado es {2}", m, n, resta);
        }

    }
}