namespace Ejercicio20;

class Program
{
    enum Months { Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Agosto, Septiembre, Octubre, Noviembre, Diciembre }
    static Months months = Months.Enero;

    static int month = (int)months;
    static void Main()
    {
        Console.WriteLine("Introduce un número entre 1 y 12");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >=1 && num <= 12)
        {
            Months mes = (Months)num;
            Console.WriteLine(mes);
        }
        else
        {
            Console.WriteLine("Tonto");
        }
    }
}