// Exercício 1:

using System.Text.RegularExpressions;

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

        Console.WriteLine("Digite suas palavras");

        string palavraUser = Console.ReadLine();

        int numeroDeCaracteres = palavraUser.Length;

        Console.WriteLine(numeroDeCaracteres);

        Console.WriteLine("Digite a placa do veículo:");

        
        string placa = Console.ReadLine();

        string padraoPlaca = @"^[a-zA-Z]{3}[0-9]{4}$";

        bool placaValida = Regex.IsMatch(placa, padraoPlaca);

        if (placaValida)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("Data completa:");
        Console.WriteLine(dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));
        Console.WriteLine();

        Console.WriteLine("Data no formato dd/MM/yyyy:");
        Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
        Console.WriteLine();

        Console.WriteLine("Hora no formato 24 horas:");
        Console.WriteLine(dataAtual.ToString("HH:mm"));
        Console.WriteLine();

        Console.WriteLine("Data com o mês por extenso:");
        Console.WriteLine(dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));
    }
}
