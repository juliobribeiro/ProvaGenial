using ProvaGenialInvestimentos.Data.Context;
using ProvaGenialInvestimentos.Domain.Entities;
using ProvaGenialInvestimentos.Domain.Interfaces.Repositories;

namespace ProvaGenialInvestimentos.Data.Repositories
{
    public class ContatoRepository : RepositoryBase<Contato>, IContatoRepository
    {
        public ContatoRepository(AngularContext Db)
            : base(Db)
        {
        }
    }
}
