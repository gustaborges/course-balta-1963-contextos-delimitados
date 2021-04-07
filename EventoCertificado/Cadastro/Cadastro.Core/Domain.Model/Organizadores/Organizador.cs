using Nucleo.Core;
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
        public NomeCompleto Nome { get; private set; }
        public NomeCompleto Responsavel { get; private set; } 
        public bool Ativo { get; private set; }
        public DateTime DataCadastro { get; private set; }
    }
}
