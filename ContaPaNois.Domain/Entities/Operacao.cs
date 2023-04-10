namespace ContaPaNois.Domain.Entities
{
    public class Operacao
    {
        public int Id { get; set; }

        public string TipoDaOperacao { get; set; }

        public Numero NumeroPreOperacao { get; set; }
        public Numero NumeroPosOperacao { get; set; }

        public Numero ValorResultado { get; set; }
    }
}