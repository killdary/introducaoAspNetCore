using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducaoAspNetCore.Services
{
    public class ProdutoService : IProdutoService
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


        public List<Produto> AddProduto(Produto produto)
        {
            produtos.Add(produto);
            return produtos;
        }

        public List<Produto> GetAllProdutos()
        {
            return produtos;
        }

        public Produto GetProdutoById(int id)
        {
            return produtos.FirstOrDefault(p => p.Id == id);
        }
    }
}