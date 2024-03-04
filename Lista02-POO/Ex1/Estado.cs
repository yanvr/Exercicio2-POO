namespace Lista02_POO.Ex1
{
    public sealed class Estado
    {
        public string Nome { get; init; } = string.Empty;
        public IEnumerable<Cidade> Cidades { get; set; } = [];

        private Estado(string nome)
        {
            Nome = nome;
        }

        public static Estado CreateInstance(string nome)
        {
            ArgumentException.ThrowIfNullOrEmpty(nome, nameof(nome));

            return new Estado(nome);
        }
    }
}