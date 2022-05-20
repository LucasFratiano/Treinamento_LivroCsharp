using System;

namespace Estacionamento;

public abstract class RedeEstacionamento
{
    public Guid Id { get; set; }

    public RedeEstacionamento()
    {
        Id = Guid.NewGuid();
    }
}
