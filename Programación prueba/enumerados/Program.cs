namespace Enumerados;

class Program
{
    enum DayOfWeek { Monday = 45, Wednesday = 57, Saturday = 3};

    public static void Main()
    {
        DayOfWeek dayOfWeek = DayOfWeek.Monday;
        Console.WriteLine((int)dayOfWeek);
        Console.WriteLine((DayOfWeek)3);
    }

}