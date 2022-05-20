using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryClass;

namespace BibliotecaV1
{
    class Program
    {
        static void Main(string[] args){
            //inicializando a classe com o construtor nulo
            Biblioteca MinhaBiblioteca = new Biblioteca();
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
            Biblioteca MeusLivros = new Biblioteca("Locsfudz", "Zipersoft - Vivencia", 296,true);
            //imprimindo os valores da classe
            Console.WriteLine("Autor {0}", MeusLivros.Autor);
            Console.WriteLine("Titulo: {0}", MeusLivros.Titulo);
            Console.WriteLine("Paginas: {0}", MeusLivros.Paginas);
            Console.WriteLine("Status: {0}", MeusLivros.Status);
            Console.WriteLine();
        }
    }
}