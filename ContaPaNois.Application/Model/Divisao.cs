namespace ContaPaNois.Application.Model
{
    public class Divisao : OperacaoModel
    {
        public double NumeroADividir { get; set; }

        public override double CalcularResultado()
        {
            return NumeroInicial / NumeroADividir;
        }

        public override bool Validar()
        {
            if (NumeroADividir != 0)
                return false;

            return true;
        }
    }
}
