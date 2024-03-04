using System.Numerics;
using System.Runtime.InteropServices;

namespace Lista02_POO.Ex3
{
    public class CalculadorGeometrico
    {
        private const int ElevadoAoQuadrado = 2;
        private const int DivisorAreaTriangulo = 2;

        public double Calcular(double raio)
        {
            return Math.PI * Math.Pow(raio, ElevadoAoQuadrado);
        }

        public double Calcular(double valorBase, double altura)
        {
            return valorBase * altura;
        }

        public int Calcular(int lado1, int lado2, int lado3)
        {
            return lado1 + lado2 + lado3;
        }

        public double Calcular(int valorBase, double altura)
        {
            return (valorBase * altura) / DivisorAreaTriangulo;
        }

        public double Calcular(int[] parOrdenado1, int[] parOrdenado2, int[] parOrdenado3)
        {
            int[][] matriz = [[..parOrdenado1, 1, ..parOrdenado1],
                            [..parOrdenado2, 1, ..parOrdenado2],
                            [..parOrdenado3, 1, ..parOrdenado3]];

            int determinante = CalcularDeterminante(matriz);

            return 0.5 * determinante;
        }

        private int CalcularDeterminante(int[][] matriz)
        {
            int diagonalPrincipal = 0;
            int diagonalSecundaria = 0;

            for (int i = 0; i < matriz.Length; i++)
            {
                diagonalPrincipal += matriz[0][i] * matriz[1][i + 1] * matriz[2][i + 2];
                diagonalSecundaria += matriz[0][4 - i] * matriz[1][3 - i] * matriz[2][2 - 1];
            }

            return diagonalPrincipal + diagonalSecundaria;
        }
    }
}