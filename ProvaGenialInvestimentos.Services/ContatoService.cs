using System;
using System.Linq;
using System.Collections.Generic;
using ProvaGenialInvestimentos.Domain.Entities;
using ProvaGenialInvestimentos.Domain.Interfaces.Services;

namespace ProvaGenialInvestimentos.Services
{
    public class ContatoService : DataServiceBase<Contato>, IContatoService
    {
        private readonly IUnitOfWorkService _uow;

        public ContatoService(UnitOfWorkService uow)
            : base(uow)
        {
            _uow = uow;
        }

        public List<Contato> ObterTodos()
        {
            return GetAll().ToList();
        }
    }
}
