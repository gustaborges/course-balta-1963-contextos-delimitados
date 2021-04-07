using Cadastro.Core.Domain.Model.Organizadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Application.Organizadores
{

    // O serviço vai orquestrar o repositório e as regras do dominío
    public class ServicoOrganizador : IServicoOrganizador
    {
        private readonly IOrganizadorRepositorio _repositorio;

        public ServicoOrganizador(IOrganizadorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void CadastrarNovoOrganizador(Organizador organizador)
        {
            _repositorio.Adicionar(organizador);
        }
    }
}
