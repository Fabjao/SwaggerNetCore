using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTesteSwagger.Business;
using ApiTesteSwagger.Contract;
using Microsoft.AspNetCore.Mvc;

namespace ApiTesteSwagger.Controllers
{
    [Route("api/pessoa")]
    public class PessoaController : Controller
    {
        private readonly IPessoa _pessoaBusiness;

        public PessoaController(IPessoa pessoaBusiness)
        {
            _pessoaBusiness = pessoaBusiness;
        }

        /// <summary>
        /// Aqui vai listar todos os itens
        /// </summary>
        /// <returns>popopo</returns>
        [Route("listar")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pessoaBusiness.Lista());
        }


        /// <summary>
        /// dasdasdasdasdasda
        /// </summary>
        /// <returns>1231231</returns>
        [Route("listar/v2")]
        [HttpGet]
        public IActionResult TantoFaz()
        {
            var teste = "hello";
            return Ok(teste);
        }
       
    }
}