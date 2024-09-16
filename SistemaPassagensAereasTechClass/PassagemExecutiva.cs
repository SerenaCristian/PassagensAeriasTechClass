using SistemaReservaPassagens;

public class PassagemExecutiva : PassagemAerea
{
    public PassagemExecutiva(string origem, string destino, DateTime dataViagem, double precoBase)
        : base(origem, destino, dataViagem, precoBase)
    { }

    public override double CalcularPreco()
    {
        return PrecoBase + (PrecoBase * 0.30); 
    }
}