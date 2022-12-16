Console.WriteLine("Introduce carácter según tu estado civil");
Console.WriteLine("C = casado");
Console.WriteLine("S = soltero");
Console.WriteLine("V = viudo");
Console.WriteLine("D = divorciado");
string estado = Console.ReadLine();

switch (estado)
{

    case "C":
        Console.WriteLine("Casado");
        break;

    case "D":
        Console.WriteLine("divorciado");
        break;

    case "S":
        Console.WriteLine("soltero");
        break;

    case "V":
        Console.WriteLine("viudo");
        break;

    default:
        Console.WriteLine("Carácter no válido");
        break;

}
