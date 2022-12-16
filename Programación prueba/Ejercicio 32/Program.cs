namespace Ejercicio_32
{
    internal class Program
    {
        const int SIZE = 10;
        static void Main(string[] args)
        {
            int[] numbers = new int[SIZE];
            CrearArray(numbers);

            for(int i =0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i} => {numbers[i]}");
            }

            Mostrar(numbers);
        }

        static void CrearArray(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Mostrar(int[] numbers)
        {

        }
    }
}