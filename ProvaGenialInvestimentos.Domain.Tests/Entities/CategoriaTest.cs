using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProvaGenialInvestimentos.Domain.Entities;

namespace ProvaGenialInvestimentos.Domain.Tests.Entities
{
    [TestClass]
    public class CategoriaTest
    {
        Guid idCategoria = new Guid();
        DateTime dataInclusao = DateTime.Now;

        [TestMethod]
        public void DeveCadastrarUmaCategoriaComNomeCorretamente()
        {
            string nomeCategoria = "Teste Nome Categoria";

            var categoria = new Categoria(idCategoria, nomeCategoria, dataInclusao);

            Assert.AreEqual(idCategoria, categoria.IdCategoria);
            Assert.AreEqual(nomeCategoria, categoria.NomeCategoria);
            Assert.AreEqual(dataInclusao, categoria.DataInclusao);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveCadastrarUmaCategoriaComNomeNuloERetornarUmaException()
        {
            string nomeCategoria = null;

            var categoria = new Categoria(idCategoria, nomeCategoria, dataInclusao);
        }


    }
}
