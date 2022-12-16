using System.Globalization;
using System.Linq.Expressions;

namespace Ejercicio_23;

class Program
{
    static void Main()
    {
        try
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            int num1, num2, division;
            num1 = Entero();
            num2 = Entero();
            division = num1 / num2;
            Console.WriteLine($"El resultado es {division}");
        }
        catch (Exception)
        {
            Console.WriteLine("Debes introducir un valor válido");
        }
        
    }

    static int Entero()
    {
        Console.WriteLine("Introduce un número entero");
        return int.Parse(Console.ReadLine());
    }
}
