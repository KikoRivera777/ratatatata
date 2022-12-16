namespace Ejercicio21;

class Program
{

    enum Days { Lunes, Martes, Miércoles, Jueves, Viernes, Sábado, Domingo}
    static Days days = Days.Lunes;

    static void Main()
    {
        Console.WriteLine("Introduce un día de la semana");
        Days dia = (Days)Enum.Parse(typeof(Days), Console.ReadLine(), true);
        int dia2 = (int)dia;

        if (dia2 <=4)
        {
            Console.WriteLine("Día laborable");
        }
        else
        {
            Console.WriteLine("Día no laborable");
        }
    }

}