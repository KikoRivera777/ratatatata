Console.WriteLine("Introduce tu edad");
int edad = Convert.ToInt32(Console.ReadLine());

switch (edad)
{

    case < 18:
        Console.WriteLine("Menor de edad");
        break;

    case >= 65:
        Console.WriteLine("Jubilado");
        break;

    case >= 18:
        Console.WriteLine("Activo");
        break;
}
