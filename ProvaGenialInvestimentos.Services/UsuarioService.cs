using ProvaGenialInvestimentos.Domain.Entities;
using ProvaGenialInvestimentos.Domain.Interfaces.Services;

namespace ProvaGenialInvestimentos.Services
{
    public class UsuarioService : DataServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUnitOfWorkService _uow;

        public UsuarioService(UnitOfWorkService uow)
            : base(uow)
        {
            _uow = uow;
        }
    }
}
