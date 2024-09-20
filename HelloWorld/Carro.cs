using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld;
public class Carro
{
    public string Modelo { get; set; }
    public DateOnly LancadoEm { get; set; }
    public Cor Cor { get; set; }

    public Carro(string modelo)
    {
        Modelo = modelo;
    }
    public void NomeDoModelo() => Console.WriteLine(Modelo);
}