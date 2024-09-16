using SistemaReservaPassagens;

public class PassagemPrimeiraClasse : PassagemAerea
{
    public bool ServicoDeBordo { get; private set; }

    public PassagemPrimeiraClasse(string origem, string destino, DateTime dataViagem, double precoBase, bool servicoDeBordo)
        : base(origem, destino, dataViagem, precoBase)
    {
        ServicoDeBordo = servicoDeBordo;
    }

    public override double CalcularPreco()
    {
        double preco = PrecoBase + (PrecoBase * 0.50); 
        if (ServicoDeBordo)
        {
            Console.WriteLine("Serviço de bordo incluído.");
        }
        return preco;
    }
}
