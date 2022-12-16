namespace Excepciones;

class Program
{
    public static void Main()
    {

        string request = "google.com";
        string page = "";
        Random random = new Random();

        try
        {
            if (random.NextDouble() < 0.5)
            throw new Exception("No hoy internet");

            page = request;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            page = "localhost/dinosaurio.com";
        }
        finally
        {
            Console.WriteLine($"Estas en la página: {page}");
        }

        Console.WriteLine("Pídeme otra cosa");

    }
}