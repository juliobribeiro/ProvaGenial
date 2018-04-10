using System;

namespace ProvaGenialInvestimentos.Domain.Entities
{
    public class Usuario
    {
        #region Properts
        public Guid IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataInclusao { get; set; }
        #endregion

        #region Constructor
        public Usuario(Guid idUsuario, string nomeUsuario, string login, string senha, DateTime dataInclusao)
        {
            if (string.IsNullOrWhiteSpace(nomeUsuario))
                throw new ArgumentNullException(nameof(nomeUsuario));

            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentNullException(nameof(login));

            if (string.IsNullOrWhiteSpace(senha))
                throw new ArgumentNullException(nameof(senha));

            this.IdUsuario = idUsuario;
            this.NomeUsuario = nomeUsuario;
            this.Login = login;
            this.Senha = senha;
            this.DataInclusao = dataInclusao;
        }
        #endregion

    }
}
