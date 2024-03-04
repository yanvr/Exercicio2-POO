namespace Lista02_POO.Ex1
{
    public sealed class Cliente
    {
        public string Nome { get; init; } = string.Empty!;
        public Cpf Cpf { get; init; } = null!;
        public Endereco Endereco { get; init; } = null!;

        private Cliente(string nome, Cpf cpf, Endereco endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }

        public static Cliente CreateInstance(string nome, string cpf, string logradouro,
            string numero, string bairro, string cidade, string estado)
        {
            ArgumentException.ThrowIfNullOrEmpty(nome, nameof(nome));

            var endereco = Endereco.CreateInstance(logradouro, numero, bairro, cidade, estado);
            var numeroCpf = Cpf.CreateInstance(cpf);

            return new Cliente(
                nome,
                numeroCpf,
                endereco);
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                $"CPF: {Cpf.Valor}\n" +
                $"Logradouro : {Endereco.Logradouro}\n" +
                $"Número : {Endereco.Numero}\n" +
                $"Bairro : {Endereco.Bairro}\n" +
                $"Cidade : {Endereco.Cidade.Nome}\n" +
                $"Estado : {Endereco.Cidade.Estado.Nome}";
        }
    }
}