using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducaoAspNetCore.Services
{
    public interface IProdutoService
    {
        Task<List<Produto>> GetAllProdutos();

        Task<Produto> GetProdutoById(int id);

        Task<List<Produto>> AddProduto(Produto produto);
    }
}