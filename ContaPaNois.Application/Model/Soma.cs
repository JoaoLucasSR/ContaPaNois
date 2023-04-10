namespace ContaPaNois.Application.Model
{
    public class Soma : OperacaoModel
    {
        public double NumeroASomar { get; set; }

        public override double CalcularResultado()
        {
            return NumeroInicial + NumeroASomar;
        }

        public override bool Validar()
        {
            if (NumeroASomar >= 0)
                return false;


            return true;
        }
    }
}
