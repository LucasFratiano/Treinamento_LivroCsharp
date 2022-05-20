using System;
namespace PrimeiraClasse{
    class ProgramPrincipal{
        static void Main(string[] args){
            #region ComentarioJaFizModoEstruturado
            // declaramos uma variavel do tipo string
            // string digitado = new String("");
            // solicitamos que o usuario digite alguma coisa e armazene na variavel criada
            // digitado = Console.ReadLine();
            // mostramos o que foi digitado
            // Console.WriteLine(digitado);   
            #endregion

            InteracaoUsuario Pedido = new InteracaoUsuario();

            var digitado = Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao(digitado);


        }
    }

    class InteracaoUsuario{
        public string? SolicitarDigitacao(){
            return Console.ReadLine();
        }
        public void MostrarDigitacao(string digitado){
            Console.WriteLine(digitado);
        }
    }

}   