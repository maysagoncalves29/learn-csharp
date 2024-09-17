using System.Globalization;

namespace HelloWorld;

class Program
{
    //lista: apenas uma dimensão. não tem tamanho fixo.
    static void Main()
    {
       List<int> inteiros = new List<int>();
        inteiros.Add(1);
        Console.WriteLine(inteiros.Count);

        List<object> objetos = new List<object>();

        objetos.Add(1);
        objetos.Add("String");
        objetos.Add(true);
        Console.WriteLine(objetos.Count);
    }
}
