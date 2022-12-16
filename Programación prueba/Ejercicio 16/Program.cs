using System.Diagnostics.Metrics;

Console.WriteLine("Introduzca un número en base 10");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduzca la base a la que desee cambiar");
int base1 = Convert.ToInt32(Console.ReadLine());

string resultado = "";
string resultado2 = "";
int resto = 0;

if (base1 <= 9 && base1 >= 2)
{
    for (int i = num; num > 0 ; i--)
    {
        resto = num % base1;
        num /= base1;
        resultado += resto;
    }
    for (int j = resultado.Length - 1; j >= 0; j--)
    {
        resultado2 += resultado[j];
    }
    Console.Write($"{resultado2}");

}
else
{
    Console.WriteLine("Escriba en número entre 2 y 9");
}

Console.WriteLine("\nPulsa enter para cerrar");
Console.ReadLine();