using System;
using MinhaClasseUsuario;
namespace PrimeiraClasse
{
    class ProgramPrincipal
    {
        static void Main(string[] args)
        {
            #region ComentarioJaFizModoEstruturado
            // declaramos uma variavel do tipo string
            // string digitado = new String("");
            // solicitamos que o usuario digite alguma coisa e armazene na variavel criada
            // digitado = Console.ReadLine();
            // mostramos o que foi digitado
            // Console.WriteLine(digitado);   
            #endregion

            //Criamos o objeto Pedido herdado da clase InteracaoUsuario     
            InteracaoUsuario Pedido = new InteracaoUsuario();

            //Invocamos os metodos do objeto Pedido herdado da classe mãe InteracaoUsuario
            Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao();

            //recupero pelo metodo get o valor da mensagem digitada
            //para futura manipulacao
            var digitado = Pedido.Mensagem;

            Console.WriteLine("Nova Digitaçao em maisculo" + digitado.ToUpper());


        }
    }

}