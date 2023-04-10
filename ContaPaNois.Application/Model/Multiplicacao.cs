namespace ContaPaNois.Application.Model
{
    public class Multiplicacao : OperacaoModel
    {
        public double NumeroAMultiplicar { get; set; }

        public override double CalcularResultado()
        {
            return NumeroInicial * NumeroAMultiplicar;
        }

        public override bool Validar()
        {
            return true;
        }
    }
}
