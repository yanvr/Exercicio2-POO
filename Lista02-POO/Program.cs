using Lista02_POO.Ex1;
using Lista02_POO.Ex2;
using Lista02_POO.Ex3;
using Lista02_POO.Ex4;
using Lista02_POO.Ex5;
using Lista02_POO.Utils;

string opcao = string.Empty;

var questoes = new Dictionary<string, Action>()
    {
        { "1", () => Ex1() },
        { "2", () => Ex2() },
        { "3", () => Ex3() },
        { "4", () => Ex4() },
        { "5", () => Ex5() },
        { "6", () => Ex6() },
        { "7", () => Environment.Exit(0) }
    };

do
{
    Console.WriteLine(
    @"Qual exercício você deseja executar:
    1- Cadastro de cliente
    2- Contar primos
    3- Calcular área geométrica
    4- Calculadora
    5- Diferença de dia entre datas
    6- Validador CPF
    7- Sair");

    opcao = Console.ReadLine()!;
    Console.Clear();

    if (questoes.TryGetValue(opcao, out Action? value))
        value();
}
while (opcao != "7");

static void Ex1()
{
    try
    {
        Console.WriteLine("Informe o nome: ");
        string nome = Console.ReadLine()!;

        Console.WriteLine("Informe o CPF: ");
        string cpf = Console.ReadLine()!;

        Console.WriteLine("Informe o logradouro: ");
        string logradouro = Console.ReadLine()!;

        Console.WriteLine("Informe o número: ");
        string numero = Console.ReadLine()!;

        Console.WriteLine("Informe o bairro: ");
        string bairro = Console.ReadLine()!;

        Console.WriteLine("Informe a cidade: ");
        string cidade = Console.ReadLine()!;

        Console.WriteLine("Informe o estado: ");
        string estado = Console.ReadLine()!;

        Cliente cliente = Cliente.CreateInstance(nome, cpf, logradouro, numero, bairro, cidade, estado);

        Console.WriteLine(cliente.ToString());
    }
    catch (Exception e)
    {
        Console.WriteLine("Ocorreu um erro no cadastro do cliente");
    }
}

static void Ex2()
{
    Console.WriteLine("Informe o número 1: ");
    int n1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Informe o número 2: ");
    int n2 = int.Parse(Console.ReadLine()!);

    Contador contador = new();

    Console.WriteLine($"A quantidade de número primos entre o número {n1} e {n2} são {contador.ContarPrimos(n1, n2)}");
}

static void Ex3()
{
    try
    {
        Console.WriteLine(
        @"Qual operação você deseja executar:
        1- Área do círculo
        2- Área do quadrado
        3- Perímetro do triângulo
        4- Área do triângulo
        5- Área do triângulo pares ordenados");

        var operacao = Console.ReadLine();

        CalculadorGeometrico calculadora = new();

        if (operacao == "1")
        {
            Console.WriteLine("Informe o valor do raio do círculo: ");
            double raio = double.Parse(Console.ReadLine()!);
            double areaCirculo = calculadora.Calcular(raio);
        }
        else if (operacao == "2")
        {
            Console.WriteLine("Informe o valor da base do quadrado: ");
            double valorBase = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o valor da altura do quadrado: ");
            double altura = double.Parse(Console.ReadLine()!);

            double areaQuadrado = calculadora.Calcular(valorBase, altura);
        }
        else if (operacao == "3")
        {
            Console.WriteLine("Informe o valor do lado 1 do triângulo: ");
            int lado1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o valor do lado 2 do triângulo: ");
            int lado2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o valor do lado 3 do triângulo: ");
            int lado3 = int.Parse(Console.ReadLine()!);

            int perimetroTriangulo = calculadora.Calcular(lado1, lado2, lado3);
        }
        else if (operacao == "4")
        {
            Console.WriteLine("Informe o valor da base do quadrado: ");
            int valorBase = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o valor da altura do quadrado: ");
            double altura = int.Parse(Console.ReadLine()!);

            double areaTriangulo = calculadora.Calcular(valorBase, altura);
        }
        else if (operacao == "5")
        {
            Console.WriteLine("Informe o valor da par ordenado 1: ");
            int[] parOrdenado1 = Console.ReadLine()!
                                    .Split(" ")
                                    .Select(x => int.Parse(x))
                                    .ToArray();

            Console.WriteLine("Informe o valor da par ordenado 2: ");
            int[] parOrdenado2 = Console.ReadLine()!
                                   .Split(" ")
                                   .Select(x => int.Parse(x))
                                   .ToArray();

            Console.WriteLine("Informe o valor da par ordenado 3: ");
            int[] parOrdenado3 = Console.ReadLine()!
                                   .Split(" ")
                                   .Select(x => int.Parse(x))
                                   .ToArray();

            double areaTriangulo = calculadora.Calcular(parOrdenado1, parOrdenado2, parOrdenado3);
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Uso incorreto");
    }
}

static void Ex4()
{
    Console.WriteLine("Informe o número 1: ");
    int n1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Informe o número 2: ");
    int n2 = int.Parse(Console.ReadLine()!);

    Calculadora calculadora = new();

    Console.WriteLine($"A soma do número {n1} + {n2} é: {calculadora.Somar(n1, n2)}");
    Console.WriteLine($"A subtração do número {n1} - {n2} é: {calculadora.Subtrair(n1, n2)}");
    Console.WriteLine($"A divisão do número {n1} / {n2} é: {calculadora.Dividir(n1, n2)}");
    Console.WriteLine($"A multiplicão do número {n1} * {n2} é: {calculadora.Multiplicar(n1, n2)}");
    Console.WriteLine($"A raiz quadrado do número do número 1 é : {calculadora.Radiciar(n1)} e do número 2 é : {calculadora.Radiciar(n2)}");
    Console.WriteLine($"O fatorial do número 1 é : {calculadora.CalcularFatorial(n1)} e do número 2 é : {calculadora.CalcularFatorial(n2)}");
}

static void Ex5()
{
    Console.WriteLine("Informe uma data inicial: ");
    DateTime dataInicial = DateTime.Parse(Console.ReadLine()!);

    Console.WriteLine("Informe uma data final: ");
    DateTime dataFinal = DateTime.Parse(Console.ReadLine()!);

    ManipuladorData manipulador = new();

    Console.WriteLine($"A diferença de dias entre as duas datas é {manipulador.CalcularDiferencaDias(dataInicial, dataFinal)}");
}

static void Ex6()
{
    Console.WriteLine("Informe um CPF para ser válidado: ");
    string? cpf = Console.ReadLine();

    if (string.IsNullOrEmpty(cpf) ||
        !ValidadorCpf.Validar(cpf))
    {
        Console.WriteLine("O CPF informado é inválido");
    }
    else
    {
        Console.WriteLine("O CPF informado é válido");
    }
}