using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Questao5.Infrastructure.Database;
using Questao5.Infrastructure.Database.CommandStore.Requests;
using Questao5.Infrastructure.Database.CommandStore.Responses;

namespace Questao5.Infrastructure.Services
{
    public class ContaCorrenteService : IContaCorrentService
    {
        public readonly IContaCorrenteDatabase _contaCorrenteDataba;
        
        public ContaCorrenteService(IContaCorrenteDatabase contaCorrenteDb)
        {
            _contaCorrenteDataba = contaCorrenteDb;
        }

        public ResponseMovimento consultaSaldo(int idConta)
        {
             return _contaCorrenteDatabase.consultaSaldo(idConta);
        }

        public ResponseMovimento movimentoConta(RequestMovimento requestConta)
        {
            return _contaCorrenteDatabase.movimentoConta(requestConta);
        }
    }
}