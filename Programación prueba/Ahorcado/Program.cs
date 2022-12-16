using System.Linq.Expressions;

namespace Ahorcado
{
    internal class Program
    {
        const int attempt = 8; //constante para igualarla luego a los intentos puñeta
        static int attempts = attempt; //aquí igualo el entero a la constante de arriba
        static char letter = ' ';
        static bool playing = true;
        static string[] words = new string[] { "variable", "enumerados", "codin game", "programacion", "visual studio" };
        static string finalWord;
        static string orderWord = "";
        enum Result { Playing, Succes, Defeat }
        static Result result = Result.Playing;
        static void Main()
        {
            if (result == Result.Playing || result == Result.Succes || result == Result.Defeat) ;
            {
                if (result == Result.Playing)
                {
                    Playing();
                }
                else if (result == Result.Succes)
                {
                    Succes();
                }
                else if (result == Result.Defeat)
                {
                    Defeat();
                }
            }
        }
        static void ShowWordDefeat()
        {
            Console.WriteLine($"Mala suerte, la palabra era {finalWord}, intenta hacerlo mejor para la próxima");
            Console.WriteLine("No te vengas abajo, prueba otra vez!! :)");
            Console.WriteLine("\n");
            Console.WriteLine("Pulsa cualquier tecla para salir");
        }
        static void ShowWordSucces()
        {
            Console.WriteLine($"Felicidades maestro, la palabra era {finalWord}, estás hecho un máquina");
            Console.WriteLine("Prueba a darle a otra partida!!! :)");
            Console.WriteLine("\n");
            Console.WriteLine("Pulsa cualquier tecla para salir");
        }
        //un porro convertido en método
        static string WordsOrdered(string orderWord)
        {
            //se crea un array de char para ir metiendo las letras usadas dentro
            char[] lettersRight = new char[orderWord.Length];
            for (int i = 0; i < orderWord.Length; i++)
            {
                lettersRight[i] = orderWord[i];
            }
            //este primer for se ocupa de comparar el primer carácter que haya en el char con todos los demás
            for (int i = 0; i < lettersRight.Length; i++)
            {
                //este segundo for hace lo mismo que el primero pero con el segundo carácter
                for (int j = i + 1; j < lettersRight.Length; j++)
                {
                    /*creo una variable auxiliar para que ordene las letras en función de su posición en la tabla ASCII,
                    Parallel intercambiarlos de posicion*/
                    char sortingLetters;
                    if (lettersRight[i] > lettersRight[j])
                    {
                        sortingLetters = lettersRight[i];
                        lettersRight[i] = lettersRight[j];
                        lettersRight[j] = sortingLetters;
                    }
                }
            }

            string lettersFinallySorted = "Letras usadas: [" + String.Join( ",", lettersRight) + "]";
            return lettersFinallySorted;
        }
        static bool LetterRepeat(char letter, string orderWord)
        {
            bool repeatpeat;
            //si el array de las letras es igual a la letra que introduces entnces el booleano es falso y no la escribe
            if (orderWord.Contains(letter))
            {
                repeatpeat = false;
            }
            else
            {
                repeatpeat = true;
            }
            return repeatpeat;
        }
        static void Drawing()
        {
            switch (attempts)
            {
                case 8:
                    Console.WriteLine("-");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("-" + "-" + "-");
                    break;
                case 7:
                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("-" + "-" + "-");
                    break;
                case 6:
                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                    Console.WriteLine("|" + " " + " " + " " + "|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("-" + "-" + "-");
                    break;
                case 5:
                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                    Console.WriteLine("|" + " " + " " + " " + "|");
                    Console.WriteLine("|" + " " + " " + " " + "O");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("-" + "-" + "-");
                    break;
                case 4:
                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                    Console.WriteLine("|" + " " + " " + " " + "|");
                    Console.WriteLine("|" + " " + " " + " " + "O");
                    Console.WriteLine("|" + " " + " " + " " + "|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("-" + "-" + "-");
                    break;
                case 3:
                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                    Console.WriteLine("|" + " " + " " + " " + "|");
                    Console.WriteLine("|" + " " + " " + " " + "O");
                    Console.WriteLine("|" + " " + " " + "/" + "|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("-" + "-" + "-");
                    break;
                case 2:
                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                    Console.WriteLine("|" + " " + " " + " " + "|");
                    Console.WriteLine("|" + " " + " " + " " + "O");
                    Console.WriteLine("|" + " " + " " + "/" + "|" + "\\");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("-" + "-" + "-");
                    break;
                case 1:
                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                    Console.WriteLine("|" + " " + " " + " " + "|");
                    Console.WriteLine("|" + " " + " " + " " + "O");
                    Console.WriteLine("|" + " " + " " + "/" + "|" + "\\");
                    Console.WriteLine("|" + " " + " " + "/");
                    Console.WriteLine("|");
                    Console.WriteLine("-" + "-" + "-");
                    break;
            }
        }
        static void Playing()
        {
            //Generador de palabra random
            Random random = new Random();
            int word = random.Next(words.Length);
            finalWord = words[word];

            //ocultar palabra
            string misteryWord = "";
            for (int i = 0; i < finalWord.Length; i++)
            {
                if (finalWord[i] == ' ')
                {
                    misteryWord += " ";
                }
                else
                {
                    misteryWord += "-";
                }

            }

            //todo el metodo de playing va dentro de un booleano true para que el juego termine cuando este sea falso
            while (playing)
            {
                Console.WriteLine($"Palabra a adivinar: {misteryWord}");
                Console.WriteLine($"Intentos restantes: {attempts}");
                if (LetterRepeat(letter, orderWord))
                {
                    orderWord += letter;
                }
                Console.WriteLine(WordsOrdered(orderWord));
                Drawing();

                //esto es para leer la letra q ponga
                Console.Write("Introduce una letra: ");

                //controlar la excepción de que no introduzcas un caracter
                try
                {
                    letter = Convert.ToChar(Console.ReadLine().ToLower());
                }
                catch
                {
                    if (finalWord.Contains(letter))
                    {
                        attempts = attempts - 1;
                    }
                }

                //si la letra no coincide con la palabra generada se resta un intento
                if (!finalWord.Contains(letter))
                {
                    Console.Clear();
                    attempts--;
                }
                else
                {
                    Console.Clear();

                }

                //si la letra coincide con la palabra generada, se escribe esa letra quitando los dashes
                string guessingWord = "";
                for (int i = 0; i < finalWord.Length; i++)
                {
                    if (letter == finalWord[i])
                    {
                        guessingWord += letter;
                    }
                    else
                    {
                        guessingWord += misteryWord[i];
                    }
                }
                misteryWord = guessingWord;

                //cuando el string que va mostrando las letras correctas se queda sin dashes, se acaba la partida con el método Succes
                if (!guessingWord.Contains("-"))
                {
                    playing = false;
                    Succes();
                }

                //si los intentos = 0 se acaba la partida y se llama a Defeat
                if (attempts == 0)
                {
                    playing = false;
                    Defeat();
                }
            }
        }
        static void Defeat()
        {
            if (attempts == 0)
            {
                Console.Clear();
                Console.WriteLine("-" + "-" + "-" + "-" + "-");
                Console.WriteLine("|" + " " + " " + " " + "|");
                Console.WriteLine("|" + " " + " " + " " + "O");
                Console.WriteLine("|" + " " + " " + "/" + "|" + "\\");
                Console.WriteLine("|" + " " + " " + "/" + " " + "\\");
                Console.WriteLine("|");
                Console.WriteLine("-" + "-" + "-");
                ShowWordDefeat();
            }
        }
        static void Succes()
        {
            Console.Clear();
            ShowWordSucces();
        }
    }
}