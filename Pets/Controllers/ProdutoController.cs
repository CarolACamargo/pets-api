using Domain.Interfaces;
using Domain.Models;
using InfraData.DataContext;
using InfraData.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Pets.Controllers
{
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        public IProdutoRepository _produtoRepository{ get; set; }

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpPost("salvar-produto")]
        public async Task<IActionResult> SalvarProduto()
        {
            //    using (var context = new PetsDataContext())
            //    {
            //        var test = context.Produtos.First();
            //        context.Produtos.Add(new Produto(
            //            "Shampoo", "Shampoo para cachorros", 10, null));
            //        context.SaveChanges();
            //    }

            //var context = new PetsDataContext();
            //var produtoRepository = new ProdutoRepository(context);

            //var produto = new Produto("Shampoo2", "Shampoo para cachorros", 10, null);
            //_produtoRepository.Add(produto);
            //_produtoRepository.SaveChanges();                   

            return await Task.FromResult(Ok());
        }

        [HttpGet("buscar-produto/{id}")]
        public async Task<IActionResult> BuscarProduto(Guid id)
        {
            var produto = _produtoRepository.Get(id);
            return await Task.FromResult(Ok(produto));
        }

        [HttpGet("buscar-produtos-venda")]
        public async Task<IActionResult> BuscarProdutosVenda()
        {
            var produtos = _produtoRepository.GetAll();
            return await Task.FromResult(Ok(produtos));
        }

    }
}
