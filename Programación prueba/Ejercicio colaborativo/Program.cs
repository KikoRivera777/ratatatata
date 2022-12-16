using System.Globalization;

Console.WriteLine("Introduzca un número entero");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num*2; i++)
{

        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }

}