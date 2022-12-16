using System.Globalization;
int temp;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Introduzca la temperatura en Fº ");
temp = Convert.ToInt32(Console.ReadLine());

Console.Write("La temperatura es de ");
Console.Write((temp - 32) * 5 / 9);
Console.WriteLine(" Cº");