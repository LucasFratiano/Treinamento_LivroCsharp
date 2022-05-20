using static System.Console;
using System;
using System.Collections.Generic;

namespace Listas{

public class ExemploLista
{
    public static void Main(string[] args)
    {
        #region ComentarioDoqJaFiz
        // List<string> nomesFuncionarios = new List<string>();
        // nomesFuncionarios.Add("Maria");
        // nomesFuncionarios.Add("João");
        // nomesFuncionarios.Add("André");
        // nomesFuncionarios.Add("Flávia");

        // Console.WriteLine();
        // nomesFuncionarios.RemoveAt(0);
        // Console.WriteLine(nomesFuncionarios[0]);


        // foreach (string pessoa in nomesFuncionarios)
        // {
        //     WriteLine(pessoa);
        // }🔥🔥🔥🔥🔥🔥🔥🔥🔥
        #endregion

        ListaGenerica<int> lista1 = new ListaGenerica<int>();
        lista1.Adicionar(2);

        ListaGenerica<string> lista2 = new ListaGenerica<string>();
        lista2.Adicionar("takezo pelado");

        ListaGenerica<ExampleClass> lista3 = new ListaGenerica<ExampleClass>();
        lista3.Adicionar(new ExampleClass());

    }
}

public class ExampleClass { }
}
