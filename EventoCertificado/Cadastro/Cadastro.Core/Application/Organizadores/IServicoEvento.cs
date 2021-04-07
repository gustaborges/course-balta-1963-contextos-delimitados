using Cadastro.Core.Domain.Model.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Application
{
    public interface IServicoEvento
    {
        Evento RecuperarEvento(EventoId eventoId);
    }
}
