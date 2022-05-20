using static System.Console;
using System.Linq;
using System.Globalization;
using System;

namespace Estacionamento;

public class Program
{
    static void Main(string[] args)
    {
        var Carro = new Carro{
            Placa = Guid.NewGuid(),
            Marca = "Ford",
            Modelo = "Citroen C4",
            InicioEstacionado = DateTime.Now,
            SaidaEstacionado = DateTime.Now.AddHours(2)
        };

        WriteLine("Placa: {0}", Carro.Placa);
        WriteLine("Marca: {0}", Carro.Marca);
        WriteLine("Modelo: {0}", Carro.Modelo);
        WriteLine("Entrada no Estacionamento: {0}", Carro.InicioEstacionado.ToString("dd/MMMM/yyyy"));
        WriteLine("Saida do Estacionamento: {0}", Carro.SaidaEstacionado.ToString("dd/MMM/yyyy"));


    }
}
