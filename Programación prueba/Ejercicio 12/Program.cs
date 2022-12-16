using System.Diagnostics.Tracing;

Console.WriteLine("Introduzca una palabra");
string word = Console.ReadLine();

bool isPalindrome = true;

for (int i = 0; i < word.Length && isPalindrome; i++)
{

    if (word[i] != word[word.Length - i - 1])
    {

        isPalindrome = false;

    }
}

if (isPalindrome)
    Console.WriteLine($"La palabra {word} es un palíndromo");
else
    Console.WriteLine($"La palabra {word} no es un palíndromo");