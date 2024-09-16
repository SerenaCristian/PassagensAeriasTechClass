using SistemaReservasPassagensAereasTechClass;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente("João");

        PassagemEconomica economica = new PassagemEconomica("São Paulo", "Rio de Janeiro", DateTime.Now, 500, true);
        PassagemExecutiva executiva = new PassagemExecutiva("São Paulo", "Nova York", DateTime.Now, 1500);
        PassagemPrimeiraClasse primeiraClasse = new PassagemPrimeiraClasse("São Paulo", "Paris", DateTime.Now, 3000, true);

        cliente.ReservarPassagem(economica);
        cliente.ReservarPassagem(executiva);
        cliente.ReservarPassagem(primeiraClasse);

        cliente.ListarReservas();

        double total = cliente.CalcularTotalReservas();
        Console.WriteLine($"\nTotal das reservas: R${total:0.00}");
    }
}

