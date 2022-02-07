using Domain.Interfaces;
using Domain.Models;
using InfraData.Base;
using InfraData.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraData.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(PetsDataContext petsDataContext) : base(petsDataContext)
        {
        }

        public IQueryable<Produto> BuscarProdutosPeloNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
