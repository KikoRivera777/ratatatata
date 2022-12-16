namespace Ejercicio_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            double suma = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += i + 1;
            }

            foreach (int num in numbers)
            {
                suma += num;
            }
            Console.WriteLine($"Media:{suma / numbers.Length}");
        }
    }
}