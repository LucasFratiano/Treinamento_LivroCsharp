namespace Estacionamento;

public class Estacionamento : RedeEstacionamento
{
    public int NumeroVagas { get; set; } = 10;
    public List<Carro>?  Carros { get; set; }
    // s ? é o nullable, o tipo pode ser nulo
   /*public MeioPagamento MeioPagamento{get ; set;}
    public bool VerificaPagamento()
    {
        //Verificar forma pagamento
        if(MeioPagamento.Credito){



        }
        //VerificarPagamento se ta pago ou deram calote 
        return true;

    }*/
}

