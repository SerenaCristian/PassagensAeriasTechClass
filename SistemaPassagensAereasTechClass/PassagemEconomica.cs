using SistemaReservaPassagens;

public class PassagemEconomica : PassagemAerea
{
    public bool ClienteFrequente { get; private set; }

    public PassagemEconomica(string origem, string destino, DateTime dataViagem, double precoBase, bool clienteFrequente)
        : base(origem, destino, dataViagem, precoBase)
    {
        ClienteFrequente = clienteFrequente;
    }

    public override double CalcularPreco()
    {
        double preco = PrecoBase;
        if (ClienteFrequente)
        {
            preco -= PrecoBase * 0.10; 
        }
        return preco;
    }
}
