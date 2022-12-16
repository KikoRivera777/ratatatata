Console.WriteLine("Introduzca número de semilla");
int semilla = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduzca número de caracteres");
int caracteres = Convert.ToInt32(Console.ReadLine());
Random random = new Random(semilla);

for (int i = 0; i < caracteres; i++)
{

    int randomNumber = random.Next(256);
    Console.Write((char)randomNumber);

}