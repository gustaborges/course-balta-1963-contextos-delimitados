using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentidadeAcesso.Core
{
    class Usuario
    {
        public Usuario(LocatarioId locatarioId)
        {
            LocatarioId = locatarioId;
        }

        public LocatarioId LocatarioId { get; }
        public string NomeDeUsuario { get; private set; }
        public string Senha { get; private set; }

    }
}
