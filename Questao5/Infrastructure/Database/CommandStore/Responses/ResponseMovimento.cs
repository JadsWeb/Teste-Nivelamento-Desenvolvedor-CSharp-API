using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Questao5.Domain.Enumerators;

namespace Questao5.Infrastructure.Database.CommandStore.Responses
{
    public class ResponseMovimento
    {
        public int IdMovimento { get; set; }
        public int IdContaCorrente { get; set; }
        public double Valor { get; set; }
        public DateTime DataMovimento { get; set; }
        public TipoMovimentoEnum TipoMovimento { get; set; }
        
    }
}