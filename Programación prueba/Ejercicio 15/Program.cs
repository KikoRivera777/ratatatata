using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Introduzca un número entero");
int num = Convert.ToInt32(Console.ReadLine());

double sum = 0;

for (int i = 0; i < num; i++)
{
    sum += Convert.ToDouble(Console.ReadLine());
}

double resultado = sum / num;

Console.WriteLine($"La media aritmética es {resultado}");

Console.WriteLine();


