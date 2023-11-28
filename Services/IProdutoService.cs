using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducaoAspNetCore.Services
{
    public interface IProdutoService
    {
        List<Produto> GetAllProdutos();

        Produto GetProdutoById(int id);
        
        List<Produto> AddProduto(Produto produto);
    }
}