int a;
int b;
int c;  

Console.WriteLine("Introduce el primer lado del triángulo");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce el segundo lado del triángulo");
b = Convert.ToInt32(Console.ReadLine());    

Console.WriteLine("Introduce el tercer lado del triángulo");
c = Convert.ToInt32(Console.ReadLine());

if ((a == b) && (b == c)) 
{
    Console.WriteLine("El triángulo es equilátero");
}

else if ((a != b) && (b != c))
{
    Console.WriteLine("El triángulo es escaleno");
}

else
{
    Console.WriteLine("El triángulo es isósceles");
}
