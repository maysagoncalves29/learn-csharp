using System.Globalization;
using System.Reflection.PortableExecutable;

namespace HelloWorld;

class Program
{
    //lista: apenas uma dimensão. não tem tamanho fixo.
    static void Main()
    {
        int numero = 10;
        var meuCarro = new Carro("civic")
        {
            Cor = Cor.Vermelho,
            LancadoEm = new DateOnly(2020, 1, 1)

        };
        meuCarro.NomeDoModelo();
        Console.WriteLine("Oi");
    }
}
