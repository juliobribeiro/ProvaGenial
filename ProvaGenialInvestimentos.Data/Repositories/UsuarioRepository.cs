using ProvaGenialInvestimentos.Data.Context;
using ProvaGenialInvestimentos.Domain.Entities;
using ProvaGenialInvestimentos.Domain.Interfaces.Repositories;

namespace ProvaGenialInvestimentos.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AngularContext Db)
            : base(Db)
        {
        }
    }
}
