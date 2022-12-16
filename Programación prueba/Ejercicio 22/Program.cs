namespace Ejercicio_22
{
    internal class Program
    {
        enum Lampara {On, Off}
        static Lampara lampara = Lampara.On;

        static void Main()
        {
            Console.WriteLine("Introduce estado de la lámpara (On - Off)");
            string estado = Console.ReadLine();
            do
            {
                if (estado == "On" || estado == "Off")
                {
                    if (lampara == Lampara.On)
                    {
                        if (estado == "Off")
                        {
                            lampara = Lampara.Off;
                            Console.WriteLine("La lámpara está apagada");
                            Console.WriteLine("Introduce estado de la lámpara (On - Off)");
                            Console.ReadLine();
                        }
                        else if (estado == "On")
                        {
                            Console.WriteLine("No se puede establecer dos veces el mismo valor");
                            Console.WriteLine("Introduce estado de la lámpara (On - Off)");
                            Console.ReadLine();
                            
                        }
                    }
                    else if (lampara == Lampara.Off)
                    {
                        if (estado == "On")
                        {
                            lampara = Lampara.On;
                            Console.WriteLine("La lámpara está encendida");
                            Console.WriteLine("Introduce estado de la lámpara (On - Off)");
                            Console.ReadLine();
                        }
                        else if (estado == "Off")
                        {
                            Console.WriteLine("No se puede establecer dos veces el mismo valor");
                            Console.WriteLine("Introduce estado de la lámpara (On - Off)");
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Introduce un estado válido (On - Off)");
                    Console.ReadLine();
                }
            } while (true);
        }
    }
}