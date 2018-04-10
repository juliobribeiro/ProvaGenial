using ProvaGenialInvestimentos.Domain.Entities;
using System.Collections.Generic;

namespace ProvaGenialInvestimentos.Domain.Interfaces.Services
{
    public interface IContatoService : IDataServiceBase<Contato>
    {
        List<Contato> ObterTodos();
    }
}
