using System;

namespace SistemaReservaPassagens
{
    public class PassagemAerea
    {
        public string Origem { get; private set; }
        public string Destino { get; private set; }
        public DateTime DataViagem { get; private set; }
        public double PrecoBase { get; private set; }

        public PassagemAerea(string origem, string destino, DateTime dataViagem, double precoBase)
        {
            Origem = origem;
            Destino = destino;
            DataViagem = dataViagem;
            PrecoBase = precoBase;
        }

        public virtual double CalcularPreco()
        {
            return PrecoBase;
        }
    }
}
