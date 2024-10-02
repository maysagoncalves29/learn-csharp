// Exercício 1:

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja bem vinda.");

        Console.WriteLine("Qual é o seu sobrenome?");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"Seu nome é {nome} {sobrenome}.");
    }
}