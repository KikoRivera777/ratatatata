int num;

Console.WriteLine("Introduzca un número de dos cifras");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((num % 10) * 10 + num / 10);