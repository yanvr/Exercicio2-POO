namespace Lista02_POO.Ex4
{
    public class Calculadora
    {
        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public double Dividir(int n1, int n2)
        {
            return n1 / n2;
        }

        public double Radiciar(double n)
        {
            return Math.Sqrt(n);
        }

        public int CalcularFatorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * CalcularFatorial(n - 1);
        }
    }
}