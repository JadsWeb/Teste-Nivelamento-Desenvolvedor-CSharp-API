using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questao5.Domain.Entities
{
    public class ContaCorrente
    {
        public int IdContaCorrente { get; set; }        
        public int Numero { get; set; }
        public string? Nome { get; set; }
        public int Ativo { get; set; }
    }
}