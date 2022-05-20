using static System.Console;
using System;
using System.Linq;
using System.Globalization;
using Pedido;

namespace livrochsarp{

        public class Pedido{

            public int PedidoID { get;set;}
            public DateTime dtPedido {get; set;}
            public DateTime dtVencimento() => dtPedido.AddDays(30);
            public DateTime dtPagmento = dtPedido.AddMonths(2);
            public TimeSpan DiasAtras = dtPagmento.Subtract(dtVencimento());
            public decimal Valor {get; set;}
            public decimal Multa => Valor*0.10M;



        }

        class funcoesdatas{

            static void Main(string[] args){

                
              /*int dia = 12;
                int mes = 05;
                int ano = 2021;

                DateTime dtAniversario = new DateTime( ano, mes, dia);
                DateTime dtFesta = new DateTime( 2021, 08, 25);

                 WriteLine("------ Funções de Datas -------");
                 WriteLine($"Aniversário: {dtAniversario}");
                    WriteLine($"Aniversário: {dtAniversario:dd/MM/yyyy}");
                        WriteLine($"Aniversário: {dtAniversario:dddd/MMM/yyyy}");
                            WriteLine($"Aniversário: {dtAniversario:dddd dd/MMMM/yyyy}");*/


               /* DateTime hoje = DateTime.Today;
                WriteLine("Today - retorna data atual");
                WriteLine($"Hoje: {hoje:dd/MM/yyyy}");

                DateTime agora = DateTime.Now;
                WriteLine("Now - retorna data e hora atual");
                WriteLine($"Agora: {agora:dd/MM/yyyy hh:mm:ss}");

                DateTime agora2 = DateTime.Now;

                WriteLine($"Dia: {agora2.Day}");
                WriteLine($"Mes: {agora2.Month}");
                WriteLine($"Ano: {agora2.Year}");*/

               /* DateTime dtPedido = DateTime.Today;
                DateTime dtVencto = dtPedido.AddDays(35); // adiciona 35 dias

                //add 2 meses

                DateTime dtPagto = dtVencto.AddMonths(2);
                
                WriteLine($"Pedido feito em: {dtPedido: dd/MMM/yyyy} e vence em {dtVencto: dd/MMM/yyyy}");
                WriteLine($"Formatação completa: {dtVencto.ToLongDateString()}");
                WriteLine($"Formatação curta: {dtVencto.ToShortDateString()}");
                WriteLine($"Data para pagemento: {dtPagto: dd/MM/yyyy}");

                //dia da semana

                WriteLine($"Dia da semana: {dtVencto.DayOfWeek}");
                WriteLine($"Dia da semana em pt-br: {dtVencto.ToString("dddd", new CultureInfo("pt-BR"))}");
                WriteLine($"Número do dia da semana {(int) dtVencto.DayOfWeek}");

                //dia do ano

                WriteLine($"Dia do ano: {dtVencto.DayOfYear}");

                //subtrai 2 datas

                var qtdeDias = dtPagto.Subtract(dtPedido);

                WriteLine($"Entre o pedido e o pagamento foram {qtdeDias:dd} dias");*/

                /*WriteLine("Conversão de texto");

                string dataTexto = "30/04/2022";
                DateTime dataTextoConvertida;

                if(DateTime.TryParse(dataTexto, out dataTextoConvertida)){

                    WriteLine("Data convertida");

                }

                else{ 
                    WriteLine("Erro na conversão de data");
                }

                string dataTextoErrada = "30/meio do ano/2022";
                DateTime dataTextoErradaConvertida;

                if(DateTime.TryParse(dataTextoErrada, out dataTextoErradaConvertida)){

                    WriteLine("Data na conversão aceita");
                    
                }

                else{

                    WriteLine("Erro na conversão de data");

                }*/



                var pedido = new Pedido{

                    PedidoID = 1,
                    dtPedido = DateTime.Today,
                    dtPagmento = DateTime.Today.AddDays(45),
                    Valor = 1500

                };

                WriteLine($"Pedido: {pedido.PedidoID} - " + $"{pedido.dtPedido:dd/MMM/yyyy} - " 
                + $"{pedido.dtVencimento(): dd/NNM/yyyy} - " + $"dias atraso: {pedido.DiasAtras(): dd/MMM/yyyy} - "
                + $"valor: {pedido.Valor:n2} - " + $"multa: {pedido.Multa:n2}");






            }


        }



}
