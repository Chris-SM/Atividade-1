using System;

class Program
{
    static void Main()
    {
        char[] vet = new char[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite uma letra: ");
            vet[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nPalavra: ");
        for (int i = 0; i < 10; i++)
            Console.Write(vet[i]);
        Console.WriteLine("\n\nPalavra em várias linhas:");
        for (int i = 0; i < 10; i++)
            Console.WriteLine(vet[i]);
    }
}
