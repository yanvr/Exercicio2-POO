namespace Lista02_POO.Ex1
{
    public sealed class Endereco
    {
        public string Logradouro { get; } = string.Empty;
        public string Numero { get; } = string.Empty;
        public string Bairro { get; } = string.Empty;
        public Cidade Cidade { get; } = null!;

        private Endereco(string logradouro, string numero, string bairro, Cidade cidade)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }

        public static Endereco CreateInstance(string logradouro, string numero, string bairro, string nomeCidade, string nomeEstado)
        {
            ArgumentException.ThrowIfNullOrEmpty(logradouro, nameof(logradouro));
            ArgumentException.ThrowIfNullOrEmpty(numero, nameof(numero));
            ArgumentException.ThrowIfNullOrEmpty(bairro, nameof(bairro));

            var cidade = Cidade.CreateInstance(nomeCidade, nomeEstado);

            return new Endereco(
                logradouro,
                numero,
                bairro,
                cidade);
        }
    }
}