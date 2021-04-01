using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentidadeAcesso.Core
{
    class Locatario
    {
        public Locatario(LocatarioId locatarioId)
        {
            this.LocatarioId = locatarioId;
        }

        public LocatarioId LocatarioId { get; private set; }
        public string Nome { get; set; }

        public Usuario NovoUsuario() => new Usuario(this.LocatarioId);
    }
}
