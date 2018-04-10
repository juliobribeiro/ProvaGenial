using ProvaGenialInvestimentos.Domain.Interfaces.Services;

namespace ProvaGenialInvestimentos.Services
{
    public class ServiceBase : IServiceBase
    {
        private IUnitOfWorkService _uow;
        public ServiceBase(IUnitOfWorkService uow)
        {
            _uow = uow;
        }
    }
}
