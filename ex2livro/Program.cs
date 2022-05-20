using static System.Console;
using System;
using System.Linq;

namespace livrocsharp {

    class funcaoTexto{

        static void Main(string[] args){

        /*    WriteLine("----Funcao de texto----");
            string empresa = " Microsoft Corporation    ";

            WriteLine("TRIM - Retira os espaços em branco antes e após a expressão");
            WriteLine($"Nome sem espaços:{empresa.Trim()}");

            WriteLine();

            WriteLine("Length - retorna a quantidade de caracteres");
            WriteLine($"Tamanho do texto antes de ser limpo: {empresa.Length}");
            WriteLine($"Tamanho do texto depois de ser limpo: {empresa.Trim().Length}" );

            empresa = empresa.Trim();

            WriteLine("ToUpper - converte todos os caracteres em maiúsculo");
            WriteLine($"Texto em maiúsculo: {empresa.ToUpper()}");

            WriteLine();

            WriteLine("ToLower - o contrário do ToUpper lol");
            WriteLine($"Texto em pitico: {empresa.ToLower()}"); */

           /* var nomeUpper = "AIRTON SENNA";
            var nomeLower = "airton senna";

            //comparaçao 1

            if(nomeUpper == nomeLower){

                WriteLine("1 - nomes iguais");

            }

            else{
                WriteLine("1 - nomes diferentes");
            }

            //comparaçao 2

            if(nomeUpper.ToLower() == nomeLower){

                WriteLine("2 - nomes iguais");

            }

            else{

                WriteLine("2 - nomes diferente");

            }

            //comparaçao 3

            if(nomeUpper.Equals(nomeLower, StringComparison.OrdinalIgnoreCase)){

                WriteLine("3 - nomes iguais");

            }

            else{

                WriteLine("3 - nomes diferente");

            }*/


            /*string empresa = "Microsoft Corporation";

            WriteLine("Remove - extrai x caracteres a partir da esquerda da expressão, num de caracteres");
            WriteLine($"texto esquerdo: {empresa.Remove(9)}");

            WriteLine("Captura apenas o primeiro nome das pessoas - ou até o primeiro espaço para simplificar");

            //array string = string[] <-- array vem antes do nome da var
            string[] nomes = {"Fabricio dos Santos", "José da Silva", "Roberta Brasil"};

            foreach(var n in nomes){

                WriteLine($"{n.Remove(n.IndexOf(" "))}");

            }*/

           /* string empresa = "Microsoft Corporation";

            WriteLine("Replace - troca o conteudo de uma expressao - 1 parametro texto original, 2 parametro = novo");
            WriteLine($"Texto original: {empresa}");

            var novaempresa = empresa.Replace("Microsoft", "Google");

            WriteLine($"Texto trocado: {novaempresa}");*/

            /*WriteLine("Split -divide e extrai cada palavra em um array");

            string nivelLivro = "Este livro é básico de c#";
            string[] blocos = nivelLivro.Split(" ");
            var contador = 1;

            foreach(var exp in blocos){
                
                WriteLine($"texto {contador++}: {exp}");
                // exp vai ser a palavra que vai para o array da string blocos


            }

            WriteLine($"Quantidade de palavras: {blocos.Count()}");*/

           /* WriteLine("Substring é usado para extrair parte do texto");
            WriteLine(nivelLivro.Substring(5,14));*/

            /*string[] cesta = {"5 laranjas", "10 goiabas vermelhas", "5 pessegos doces", "5 bananas"};
            int qtde = 0;

            foreach(var p in cesta){
                //p.indexof(" ") +1 retorna a posição inicial logo após o número
                // ex: 5 laranjas = posição 1+1 = 2

                WriteLine($"{p.Substring(p.IndexOf(" ") +1)}");

                qtde += Convert.ToInt32(p.Substring(0, p.IndexOf(" ")));

            }

                WriteLine($"qtde total: {qtde:n0}");*/

            WriteLine("IsNullorEmpty verifica se a variavel está nula ou vazia");
            string nome = "Renato";
            string sobrenome = null;

            if(!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(sobrenome)){
                WriteLine($"Nome completo: {nome} {sobrenome}");
            }
            else{
                WriteLine($"Nome: {nome}");
            }






        }

    }


}