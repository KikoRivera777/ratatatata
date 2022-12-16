namespace Ejercicio_24;

class Program
{
    enum Reproductor { Inactivo, Reproduciendo, Pausado, Parado, Cerrado }
    static Reproductor reproductor = Reproductor.Inactivo;
    static void Main()
    {
        Console.WriteLine("Reproductor inactivo, introduzca acción deseada porfavor. Para ello introduzca la letra p, s o q ");
        string estado = Console.ReadLine();
        do
        {
            try
            {
                if (estado == "p" || estado == "q" || estado == "s")
                {
                    if (reproductor == Reproductor.Inactivo)
                    {
                        if (estado == "p")
                        {
                            reproductor = Reproductor.Reproduciendo;
                            Console.WriteLine("El reproductor está reproduciendo");
                            Console.WriteLine("Si desea cambiar acción escriba la letra p, s o q");
                            Console.ReadLine();
                        }
                        else if (estado == "q")
                        {
                            reproductor = Reproductor.Cerrado;
                            Console.WriteLine("El reproductor se ha cerrado");
                        }
                    }
                    else if (reproductor == Reproductor.Reproduciendo)
                    {
                        if (estado == "p")
                        {
                            reproductor = Reproductor.Pausado;
                            Console.WriteLine("El reproductor está pausado");
                            Console.WriteLine("Si desea cambiar acción escriba la letra p, s o q");
                            Console.ReadLine();
                        }
                        else if (estado == "q")
                        {
                            reproductor = Reproductor.Cerrado;
                            Console.WriteLine("El reproductor se ha cerrado");
                        }
                        else if (estado == "s")
                        {
                            reproductor = Reproductor.Parado;
                            Console.WriteLine("El reproductor está parado");
                            Console.WriteLine("Si desea cambiar acción escriba la letra p, s o q");
                            Console.ReadLine();
                        }
                    }
                    else if (reproductor == Reproductor.Pausado)
                    {
                        if (estado == "p")
                        {
                            reproductor = Reproductor.Reproduciendo;
                            Console.WriteLine("El reproductor está reproduciendo");
                            Console.WriteLine("Si desea cambiar acción escriba la letra p, s o q");
                            Console.ReadLine();
                        }
                        else if (estado == "q")
                        {
                            reproductor = Reproductor.Cerrado;
                            Console.WriteLine("El reproductor se ha cerrado");
                        }
                        else if (estado == "s")
                        {
                            reproductor = Reproductor.Parado;
                            Console.WriteLine("El reproductor está parado");
                            Console.WriteLine("Si desea cambiar acción escriba la letra p, s o q");
                            Console.ReadLine();
                        }
                    }
                    else if (reproductor == Reproductor.Parado)
                    {
                        if (estado == "q")
                        {
                            reproductor = Reproductor.Cerrado;
                            Console.WriteLine("El reproductor se ha cerrado");
                        }
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("a");
            }

        }while (reproductor != Reproductor.Cerrado);
    }
}
       