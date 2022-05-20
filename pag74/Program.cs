using static System.Console;
namespace pag74;

public class Program
{
    static void Main(string[] args)
    {
        var pedido = new Pedido() //instanciando a classe Pedido <= Objeto
        {
            PedidoId = Guid.NewGuid(),
            DtPedido = DateTime.Today,
            DtPagt = DateTime.Today.AddDays(45),
            Valor = 1500
        };

        WriteLine($"Pedido: {pedido.PedidoId} - \n{pedido.DtPedido:dd/MMM/yyy} - \nvencimento: {pedido.DtVencimento():dd/MMM/yyyy} - \ndias_atraso: {pedido.DiasAtraso().TotalDays} - \nvalor: {pedido.Valor:c} - \nmulta: {pedido.Multa():n2}");
    }


}

public class Pedido
{

    public Guid PedidoId { get; set; }
    public DateTime DtPedido { get; set; } 
    
    // dtvencimento é um método pq ele tem () e da para ser escrito com arrowFunction ( => ) pq ele só tem uma linha, dateTime e timespan de método é o tipo do retorno da funcao.
    public DateTime DtVencimento()
        => DtPedido.AddDays(30);
    public DateTime DtPagt { get; set; }
    public DateTime datavencimento => DtPedido.AddDays(30);
    public TimeSpan DiasAtraso()
        => DtPagt.Subtract(DtVencimento());
    public decimal Valor { get; set; }

    // ele só atribui o valor dele mesmo baseado em outro, entao a arFunc vai setar o valor da multa baseado no valor x 0.1, ou seja multa = 10%
    public decimal Multa() => Valor * 0.10M;

}