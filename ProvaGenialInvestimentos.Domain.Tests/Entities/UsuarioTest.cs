using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProvaGenialInvestimentos.Domain.Entities;

namespace ProvaGenialInvestimentos.Domain.Tests.Entities
{
    [TestClass]
    public class UsuarioTest
    {
        Guid idUsuario = new Guid();
        DateTime dataInclusao = DateTime.Now;
        
        [TestMethod]
        public void DeveCadastrarUmUsuarioComNomeLoginSenhaDataInclusaoCorretamente()
        {
            string nomeUsuario = "Teste Nome";
            string login = "Teste Login";
            string senha = "Teste Senha";

            var user = new Usuario(idUsuario, nomeUsuario, login, senha, dataInclusao);

            Assert.AreEqual(idUsuario, user.IdUsuario);
            Assert.AreEqual(nomeUsuario, user.NomeUsuario);
            Assert.AreEqual(login, user.Login);
            Assert.AreEqual(senha, user.Senha);
            Assert.AreEqual(dataInclusao, user.DataInclusao);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveCadastrarUmUsuarioComNomeNuloERetornarUmaException()
        {
            string nomeUsuario = null;
            string login = "Teste Login";
            string senha = "Teste Senha";

            var user = new Usuario(idUsuario, nomeUsuario, login, senha, dataInclusao);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveCadastrarUmUsuarioComLoginNuloERetornarUmaException()
        {
            string nomeUsuario = "Teste Nome";
            string login = null;
            string senha = "Teste Senha";

            var user = new Usuario(idUsuario, nomeUsuario, login, senha, dataInclusao);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveCadastrarUmUsuarioComSenhaNuloERetornarUmaException()
        {
            string nomeUsuario = "Teste Nome";
            string login = "Teste Login";
            string senha = null;

            var user = new Usuario(idUsuario, nomeUsuario, login, senha, dataInclusao);
        }

    }
}
