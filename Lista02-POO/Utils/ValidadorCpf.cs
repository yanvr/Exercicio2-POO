using System.Text.RegularExpressions;

namespace Lista02_POO.Utils
{
    public static class ValidadorCpf
    {
        private const int PosicaoPrimeiroDigitoVerificador = 9;
        private const int PosicaoSegundoDigitoVerificador = 10;

        public static bool Validar(string cpf)
        {
            const string regex = @"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})";

            if (!Regex.IsMatch(cpf, regex))
            {
                return false;
            }

            string cpfSemCaracteres = cpf.Replace(".", "").Replace("-", "");

            if (cpfSemCaracteres.Length != 11 ||
                int.Parse(cpfSemCaracteres[PosicaoPrimeiroDigitoVerificador].ToString()) != GerarDigitoVerificador(cpfSemCaracteres, PosicaoPrimeiroDigitoVerificador) ||
                int.Parse(cpfSemCaracteres[PosicaoSegundoDigitoVerificador].ToString()) != GerarDigitoVerificador(cpfSemCaracteres, PosicaoSegundoDigitoVerificador))
            {
                return false;
            }

            return true;
        }

        private static int GerarDigitoVerificador(string cpf, int posicaoDigitoVerificador)
        {
            int digitoVerificador = 0;

            for (int contador = 0; contador < posicaoDigitoVerificador; contador++)
            {
                digitoVerificador += int.Parse(cpf[contador].ToString()) * (posicaoDigitoVerificador + 1 - contador);
            }

            int restoDaDivisao = digitoVerificador % 11;

            return digitoVerificador < 2 ? 0 : 11 - restoDaDivisao;
        }
    }
}