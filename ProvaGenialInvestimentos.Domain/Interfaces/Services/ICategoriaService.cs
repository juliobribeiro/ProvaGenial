using ProvaGenialInvestimentos.Domain.Entities;
using System.Collections.Generic;

namespace ProvaGenialInvestimentos.Domain.Interfaces.Services
{
    public interface ICategoriaService : IDataServiceBase<Categoria>
    {
        List<Categoria> ObterTodas();
    }
}
