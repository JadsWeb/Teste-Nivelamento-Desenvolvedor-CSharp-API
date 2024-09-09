using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Questao5.Infrastructure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovimentoController : ControllerBase
    {
        private readonly ILogger<MovimentoController> _logger;
        private readonly IContaCorrentService contaService;

        public MovimentoController(ILogger<MovimentoController> logger, IContaCorrentService contaCorrentService)
        {
            _logger = logger;
            contaService = contaCorrentService;
        }

        [HttpPost]
        [Route("movimentacaoConta")]
        public async Task<ActionResult<ResponseMovimento>> movimentoConta(RequestMovimento requestConta)
        {
            if(requestConta.Valor < 0)
            {
                return BadRequest("Somente valores positivos.");
            }
            return Ok(_contaCorrentService.movimentoConta(requestConta));
        }

        [HttpGet]
        [Route("consultaSaldo")]
        public async Task<ActionResult<ResponseMovimento>> consultaSaldo(int idContaCorrente)
        {
            return Ok(_contaCorrentService.consultaSaldo(idContaCorrente));
        }
    }
}