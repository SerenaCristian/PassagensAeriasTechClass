using SistemaReservaPassagens;
using System;


namespace SistemaReservasPassagensAereasTechClass
{
    public class Cliente
    {
        public string Nome { get; private set; }
        private List<PassagemAerea> reservas;

        public Cliente(string nome)
        {
            Nome = nome;
            reservas = new List<PassagemAerea>();
        }

        public void ReservarPassagem(PassagemAerea passagem)
        {
            reservas.Add(passagem);
            Console.WriteLine($"{Nome} reservou uma passagem de {passagem.Origem} para {passagem.Destino}.");
        }

        public double CalcularTotalReservas()
        {
            double total = 0;
            foreach (var passagem in reservas)
            {
                total += passagem.CalcularPreco();
            }
            return total;
        }

        public void ListarReservas()
        {
            Console.WriteLine($"Reservas de {Nome}:");
            foreach (var passagem in reservas)
            {
                Console.WriteLine($"De {passagem.Origem} para {passagem.Destino}, Preço: R${passagem.CalcularPreco():0.00}");
            }
        }
    }
}

