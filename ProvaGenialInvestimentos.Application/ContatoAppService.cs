﻿using System;
using System.Linq;
using ProvaGenialInvestimentos.Domain.Entities;
using ProvaGenialInvestimentos.Domain.Interfaces.Applications;
using ProvaGenialInvestimentos.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProvaGenialInvestimentos.Application
{
    public class ContatoAppService : AppServiceBase<Contato>, IContatoAppService
    {
        private readonly IContatoService _contatoService;
        private readonly IUnitOfWorkService _uow;

        public ContatoAppService(IUnitOfWorkService uow)
            : base(uow)
        {
            _uow = uow;
            _contatoService = uow.Service<IContatoService>();
        }

        public List<Contato> ObterTodos()
        {
            return _contatoService.ObterTodos();
        }


        public void Criar(Contato contato)
        {
            Add(contato);
            _uow.Commit();
        }


        public void Alterar(Contato contato)
        {
            Update(contato);
            _uow.Commit();
        }

        public void Excluir(Guid IdContato)
        {
            Remove(Get(el => el.IdContato == IdContato));
            _uow.Commit();
        }
    }
}
