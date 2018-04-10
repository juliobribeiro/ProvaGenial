﻿using ProvaGenialInvestimentos.Domain.Entities;

namespace ProvaGenialInvestimentos.Domain.Interfaces.Applications
{
    public interface IUsuarioAppService : IAppServiceBase, IAppDataServiceBase<Usuario>
    {
        void Registrar(Usuario usuario);
        Usuario Autenticar(string login, string senha);
    }
}