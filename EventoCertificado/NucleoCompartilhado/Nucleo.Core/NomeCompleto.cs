namespace Nucleo.Core
{
    public class NomeCompleto
    {
        public NomeCompleto(string nome, string sobrenome)

        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string EscreverNome() => $"{Nome} {Sobrenome}";

    }
}
