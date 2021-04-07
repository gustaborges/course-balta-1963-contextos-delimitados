using Cadastro.Core.Domain.Model.Organizadores;
using Nucleo.Core;
using NUnit.Framework;

namespace Cadastro.Testes
{
    public class NomeCompletoTeste
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EscreverNome_DeveRetornarNomeCompleto()
        {
            var nome = new NomeCompleto("Gustavo", "Borges");
            Assert.AreEqual("Gustavo Borges", nome.EscreverNome());
        }
    }
}