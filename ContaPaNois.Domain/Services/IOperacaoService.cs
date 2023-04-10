using ContaPaNois.Domain.Entities;

namespace ContaPaNois.Domain.Services
{
    public interface IOperacaoService
    {
        public List<Operacao> RetornaTodasOperacoes();
        public Operacao RetornaAOpercao(int id);

        public void AdicionarOperacao(Operacao operacao);
        public void DeletarOperacao(int id);
    }
}
