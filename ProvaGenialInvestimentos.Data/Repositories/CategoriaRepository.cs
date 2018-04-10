using ProvaGenialInvestimentos.Data.Context;
using ProvaGenialInvestimentos.Domain.Entities;
using ProvaGenialInvestimentos.Domain.Interfaces.Repositories;

namespace ProvaGenialInvestimentos.Data.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(AngularContext Db)
            : base(Db)
        {
        }
    }
}
