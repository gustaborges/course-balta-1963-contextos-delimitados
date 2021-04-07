using Cadastro.Core.Domain.Model.Organizadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data
{
    public class OrganizadorRepositorio : IOrganizadorRepositorio
    {
        public void Adicionar(Organizador organizador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Organizador> OrganizadoresAtivos()
        {
            var organizadores = new List<Organizador>().AsQueryable();
            return organizadores.Where(OrganizadorScope.TodosAtivos); // Utilizamos o OrganizadorScrope devolveu a regra de negócio para o dominío
        }

        public IEnumerable<Organizador> OrganizadoresAtivosAnoCorrente()
        {
            var organizadores = new List<Organizador>().AsQueryable();
            return organizadores.Where(OrganizadorScope.TodosAtivosAnoCorrente(DateTime.Now.Year));
        }
    }
}
