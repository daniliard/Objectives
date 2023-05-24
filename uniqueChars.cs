using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введiть перше слово:");
        string firstWord = Console.ReadLine();

        Console.WriteLine("Введiть друге слово:");
        string secondWord = Console.ReadLine();

        var uniqueChars = firstWord.Except(secondWord).Concat(secondWord.Except(firstWord));

        Console.WriteLine("Унiкальнi символи: ");
        foreach (char c in uniqueChars)
        {
            Console.Write(c);
        }

        Console.ReadKey();
    }
}