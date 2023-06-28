using Questao5.Infrastructure.Database.CommandStore.Responses;

namespace Questao5.Infrastructure.Sqlite
{
    public interface IDatabaseBootstrap
    {
        void Setup();
        public bool verificaConta(int idContaCorrente);
        public ResponseMovimento verificaSaldo(int idContaCorrente);
    }
}