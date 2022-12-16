using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Introduzca un número entero");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Escribe {num} números");

double cant, media;
double cuad = 0;

for (int i = 0; i < num; i++)
{
    cant = Convert.ToDouble(Console.ReadLine());
    cuad += Math.Pow(cant, 2);
}

media = Math.Sqrt(cuad / num);
Console.WriteLine($"La media cuadrática es {media}");

