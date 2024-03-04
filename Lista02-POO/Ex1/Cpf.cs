using Lista02_POO.Utils;

namespace Lista02_POO.Ex1
{
    public sealed class Cpf
    {
        public string Valor { get; init; } = null!;

        private Cpf(string valor)
        {
            Valor = valor;
        }

        public static Cpf CreateInstance(string cpf)
        {
            ArgumentException.ThrowIfNullOrEmpty(cpf, nameof(cpf));

            if (!ValidadorCpf.Validar(cpf)) throw new ArgumentException("Cpf é inválido", nameof(cpf));

            return new Cpf(cpf);
        }
    }
}