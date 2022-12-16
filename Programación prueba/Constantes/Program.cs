namespace Constantes;

class Program
{
    const int TIRADAS = 50; // constantes simples
    static readonly DateTime NOW = DateTime.Now; // constantes complejas
    static readonly double CONSTANTE_COMPLEJA = Math.Cos(4);

    public static void Main()
    {
        for (int i = 0; i < TIRADAS; i++)
        {
            Console.WriteLine(i);    
        }
    }
}
