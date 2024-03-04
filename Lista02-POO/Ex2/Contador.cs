namespace Lista02_POO.Ex2
{
    public class Contador
    {
        public int ContarPrimos(int valor1, int valor2)
        {
            int qtdPrimos = 0;

            int maior;
            int menor;
            if (valor1 > valor2)
            {
                maior = valor1;
                menor = valor2;
            }
            else
            {
                maior = valor2;
                menor = valor1;
            }

            for (int i = menor; i <= maior; i++)
            {
                if (NumeroEhPrimo(i)) qtdPrimos++;
            }

            return qtdPrimos;
        }

        private bool NumeroEhPrimo(int numero)
        {
            if (numero == 1) return false;

            double raiz = Math.Sqrt(Convert.ToDouble(numero));

            for (int i = 2; i <= raiz; i++)
            {
                if (numero % i == 0) return false;
            }

            return true;
        }
    }
}