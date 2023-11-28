using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using introducaoAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace introducaoAspNetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {

        List<Produto> produtos = new List<Produto> {
            
           new Produto
            {
                Id = 1,
                Nome = "Teste 1",
                Preco = 10
            },
           new Produto
            {
                Id = 2,
                Nome = "Teste 2",
                Preco = 20
            },
           new Produto
            {
                Id = 3,
                Nome = "Teste 3",
                Preco = 30
            },
        };

        [HttpGet]
        public IActionResult Get()
        {
            var produto = produtos.First();

            return Ok(produto);
        }

        [HttpGet("All")]
        public IActionResult GetAll()
        {
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(produtos.FirstOrDefault(p => p.Id == id));
        }

        
        [HttpPost]
        public IActionResult Add(Produto produto)
        {
            produtos.Add(produto);
            return Ok(produtos);
        }
    }
}