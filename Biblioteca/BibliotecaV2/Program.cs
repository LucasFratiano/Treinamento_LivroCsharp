using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryClass;

namespace BibliotecaV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //incializando nossa nova classe com herança
            Revistas MinhasRevistas = new Revistas(3, 2022);
            Biblioteca MinhaBiblioteca = new Biblioteca();

            //inicializando as outras propriedades da classe que foram herdadas
            MinhasRevistas.Autor = "Microsoft";
            MinhasRevistas.Titulo = "MSDN Magazine";
            MinhasRevistas.Paginas = 20;
            MinhasRevistas.Status = true;

            //imprimindo os valores da minha classe
            Console.WriteLine("Revista Mes: {0}", MinhasRevistas.MesPublicacao);
            Console.WriteLine("Revista Ano: {0}", MinhasRevistas.AnoPublicacao);
            Console.WriteLine("Revista Autor: {0}", MinhasRevistas.Autor);
            Console.WriteLine("Revista Titulo: {0}", MinhasRevistas.Titulo);
            Console.WriteLine("Revista Paginas: {0}", MinhasRevistas.Paginas);
            Console.WriteLine("Revista Status: {0}", MinhasRevistas.Status);
            Console.WriteLine();

            //por isso a necessidade de setar o valor de cada propriedade
            MinhaBiblioteca.Autor = "Gabriel Fatec";
            MinhaBiblioteca.Titulo = "Zipersoft - O desespero";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
            //imprimindo os valores da classe
            Console.WriteLine("Autor {0}", MinhaBiblioteca.Autor);
            Console.WriteLine("Titulo: {0}", MinhaBiblioteca.Titulo);
            Console.WriteLine("Paginas: {0}", MinhaBiblioteca.Paginas);
            Console.WriteLine("Status: {0}", MinhaBiblioteca.Status);
            Console.WriteLine();

            //inicializando a classe com o novo construtor
            Biblioteca MeusLivros = new Biblioteca("Locsfudz", "Zipersoft - Vivencia", 296, true);
            //imprimindo os valores da classe
            Console.WriteLine("Autor {0}", MeusLivros.Autor);
            Console.WriteLine("Titulo: {0}", MeusLivros.Titulo);
            Console.WriteLine("Paginas: {0}", MeusLivros.Paginas);
            Console.WriteLine("Status: {0}", MeusLivros.Status);
            Console.WriteLine();

        }
    }
}