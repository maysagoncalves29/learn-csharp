using System.Globalization;

namespace HelloWorld;

class Program
{
    enum NivelDeDificuldade //são usados para definir um grupo de opções possíveis para uma variável. Também veremos que é possível atribuir valores numéricos específicos para cada opção do enum, desde que sejam positivos e não duplicados.
    {
        Baixo = 0,
        Médio = 2,
        Alto = 3 
    }
    static void Main()
    {
        NivelDeDificuldade nivel = NivelDeDificuldade.Alto;
        int nivelInteiro = (int)nivel;

        Console.WriteLine(nivelInteiro);
        Console.WriteLine(nivel);
        /*
        DateOnly dia = new DateOnly(2023, 12, 1);

        string diaEmTexto = dia.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));

        DateTime dia1 = new DateTime(2023, 12, 1, 20, 07, 1);
        DateTime hoje = DateTime.Now;
        Console.WriteLine(hoje);
        */
    }
}