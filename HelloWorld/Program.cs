// Exercício 1:

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Qual é o seu nome?");
        //string nome = Console.ReadLine();
       // Console.WriteLine($"Olá, {nome}! Seja bem vinda.");

        Console.WriteLine("Qual é o seu sobrenome?");
        //string sobrenome = Console.ReadLine();
        //Console.WriteLine($"Seu nome é {nome} {sobrenome}.");

        double numeral = 10.5;
        double numeral2 = 0;

        double soma = numeral + numeral2;
        Console.WriteLine($"Soma: {soma}");

        double sub = numeral - numeral2;
        Console.WriteLine($"Subtração: {sub}");

        double mult = numeral * numeral2;   
        Console.WriteLine($"Multiplicação: {mult}");
        double div = numeral / numeral2;
        Console.WriteLine($"Divisão: {div}");
        if (numeral2 != 0)
        {
            double divisao = numeral / numeral2;
            Console.WriteLine($"Divisão: {div}");
        }
        else
        {
            Console.WriteLine("Erro: Não é possível dividir por zero.");
        }
        double media = (numeral + numeral2) / 2;
        Console.WriteLine($"Média: {media}");

    }
}