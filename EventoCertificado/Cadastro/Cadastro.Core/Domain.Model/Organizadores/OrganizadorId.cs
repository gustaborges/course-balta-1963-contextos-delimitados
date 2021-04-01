using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class OrganizadorId
    {
        public OrganizadorId()
        {
            this.Id = Guid.NewGuid();
        }

        public OrganizadorId(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; protected set; }
    }
}
