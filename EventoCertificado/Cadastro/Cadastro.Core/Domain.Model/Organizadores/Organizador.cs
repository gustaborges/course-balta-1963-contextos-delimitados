using System;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class Organizador
    {
        public Organizador(OrganizadorId id, NomeCompleto nome, NomeCompleto responsavel)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Responsavel = responsavel ?? throw new ArgumentNullException(nameof(responsavel));
        }

        public OrganizadorId Id { get; private set; }
        public NomeCompleto Nome { get; set; }
        public NomeCompleto Responsavel { get; set; }
    }
}
