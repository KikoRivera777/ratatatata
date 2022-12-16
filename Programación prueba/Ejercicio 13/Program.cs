Console.WriteLine("Introduzca un número");
int num = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
bool match = false;

for (int i = 0; i < 5; i++)
{

    int randomNumber = random.Next(1, num + 1);

    Console.WriteLine(randomNumber);

    if (randomNumber == num && !match)
    {

        Console.WriteLine("Coincide");
        match = true;

    }  

}