using System;
using System.Collections.Generic;

namespace ProvaGenialInvestimentos.Domain.Entities
{
    public class Categoria
    {
        #region Properts
        public Guid IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public DateTime DataInclusao { get; set; }
        public virtual ICollection<Contato> Contato { get; set; }
        #endregion



        #region Constructor
        public Categoria(Guid idCategoria, string nomeCategoria, DateTime dataInclusao)
        {
            if (string.IsNullOrWhiteSpace(nomeCategoria))
                throw new ArgumentNullException(nameof(nomeCategoria));

            this.IdCategoria = idCategoria;
            this.NomeCategoria = nomeCategoria;
            this.DataInclusao = dataInclusao;
        }
        #endregion
    }
}
