using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using introducaoAspNetCore.Models;
using introducaoAspNetCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace introducaoAspNetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {

        IProdutoService _produoService;

        public ProdutoController(IProdutoService produoService)
        {
            _produoService = produoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_produoService.GetProdutoById(1));
        }

        [HttpGet("All")]
        public IActionResult GetAll()
        {
            return Ok(_produoService.GetAllProdutos());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_produoService.GetProdutoById(id));
        }

        
        [HttpPost]
        public IActionResult Add(Produto produto)
        {
            return Ok(_produoService.AddProduto(produto));
        }
    }
}