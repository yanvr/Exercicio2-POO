namespace Lista02_POO.Ex1
{
    public sealed class Cidade
    {
        public string Nome { get; init; } = string.Empty;
        public Estado Estado { get; init; } = null!;

        private Cidade(string nome, Estado estado)
        {
            Nome = nome;
            Estado = estado;
        }

        public static Cidade CreateInstance(string nome, string nomeEstado)
        {
            ArgumentException.ThrowIfNullOrEmpty(nome, nameof(nome));

            var estado = Estado.CreateInstance(nomeEstado);

            return new Cidade(nome, estado);
        }
    }
}