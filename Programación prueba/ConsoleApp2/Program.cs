Console.WriteLine("Introduce las dimensiones del diamante");
int dimension = Convert.ToInt32(Console.ReadLine());
int espacio, signos;

for (int i = 1; i <= dimension; i++)
{
    for (espacio = 0; espacio < dimension - i; espacio++)
    {
        Console.Write(" ");
    }
    for (signos = 0; signos < (i * 2) - 1; signos++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = dimension - 1; i <= dimension; i--)
{
    for (espacio = 0; espacio < dimension - i; espacio++)
    {
        Console.Write(" ");
    }
    for (signos = 0; signos < (i * 2) - 1; signos++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}