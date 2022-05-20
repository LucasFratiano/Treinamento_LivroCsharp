using System;

namespace Estacionamento;

public class Carro
{
    public Guid Placa { get; set; }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public DateTime InicioEstacionado { get; set; }
    public DateTime SaidaEstacionado { get; set; }
}
