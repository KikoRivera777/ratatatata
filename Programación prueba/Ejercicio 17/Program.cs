Console.WriteLine("Introduce el texto");
string text = Console.ReadLine();

string consulted = "";

for (int i = 0; i < text.Length; i++)
{
    char character = text[i];

    if (char.IsLetter (character) && !consulted.Contains(character))
    {
        int count = 0;

        for (int j = 0; j < text.Length; j++)
        {
            if (character == text[j]) count++;
        }

        Console.WriteLine($"{character} : {count}");
        consulted += character;
    }
}