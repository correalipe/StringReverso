namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        //variables
        string word, revWord = "";

        //input
        Console.WriteLine("Escreva uma palavra: ");
        word = Console.ReadLine();

        //loop & check
        for (int i  = word.Length-1; i>=0; i--)
        {
            revWord = revWord + word[i];
        }

        //output
        Console.WriteLine("Palavra de trás para frente é {0}", revWord);

        //palindromo
        if (word == revWord)
        {
            Console.WriteLine("A palavra é palíndromo");
        }
    }
}