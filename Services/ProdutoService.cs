using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using introducaoAspNetCore.Data;
using Microsoft.EntityFrameworkCore;

namespace introducaoAspNetCore.Services
{
    public class ProdutoService : IProdutoService
    {

        DatabaseContext _context;

        public ProdutoService(DatabaseContext context)
        {
            _context = context;
        }


        public async Task<List<Produto>> AddProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();


            return await _context.Produtos.ToListAsync();
        }

        public async Task<List<Produto>> GetAllProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> GetProdutoById(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }
    }
}