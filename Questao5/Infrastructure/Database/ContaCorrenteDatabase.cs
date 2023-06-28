using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Questao5.Infrastructure.Database.CommandStore;
using Questao5.Infrastructure.Database.CommandStore.Requests;
using Questao5.Infrastructure.Database.CommandStore.Responses;
using Questao5.Infrastructure.Sqlite;

namespace Questao5.Infrastructure.Database
{
    public class ContaCorrenteDatabase : IContaCorrenteDatabase
    {
        public ResponseMovimento consultaSaldo(int idContaCorrente)
        {
            throw new NotImplementedException();
        }

        public ResponseMovimento movimentoConta(RequestMovimento requestMovimento)
        {
            throw new NotImplementedException();
        }
    }
}