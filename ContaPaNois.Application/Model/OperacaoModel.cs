namespace ContaPaNois.Application.Model
{
    public abstract class OperacaoModel
    {
        public int Id { get; set; }
        public double NumeroInicial { get; set; }

        public virtual double CalcularResultado()
        {
            return 0;
        }

        public virtual bool Validar()
        { 
            return false;
        }
    }
}
