using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Questao5.Infrastructure.Database.CommandStore.Requests;
using Questao5.Infrastructure.Database.CommandStore.Responses;

namespace Questao5.Infrastructure.Database
{
    public interface IContaCorrenteDatabase
    {
        public ResponseMovimento consultaSaldo(int idContaCorrente);
        public ResponseMovimento movimentoConta(RequestMovimento requestMovimento);
    }
}