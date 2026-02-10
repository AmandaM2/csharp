using System; // Slide 7: Importando bibliotecas básicas

class Program
{
    static void Main() 
    {
        Console.WriteLine("=== AULA 01: FUNDAMENTOS E VARIÁVEIS ===");

        // ============================================================
        // 1. TIPOS DE DADOS E VARIÁVEIS (Baseado nos Slides 8, 9 e 10)
        // ============================================================

        // Números Inteiros (Slide 8)
        int idade = 22;              // 'int' é o padrão para números sem vírgula
        long populacaoMundial = 8000000000; // 'long' é para números gigantes

        // Números Decimais (Slide 8 - Atenção aos sufixos!)
        double altura = 1.75;        // 'double' é o padrão para decimais
        float peso = 70.5f;          // 'float' precisa do 'f' no final (menos preciso)
        decimal saldoBancario = 1500.99m; // 'decimal' precisa do 'm'. OBRIGATÓRIO para dinheiro!

        // Texto e Caracteres (Slide 9)
        char inicial = 'A';          // 'char' usa aspas simples (um caractere só)
        string nome = "Amanda";      // 'string' usa aspas duplas (texto)

        // Lógica (Slide 9)
        bool estaEstudando = true;   // 'bool' só aceita true (verdadeiro) ou false (falso)

        // Inferência de Tipo (Slide 9)
        var curso = "Engenharia de Software"; // O C# descobre sozinho que é string

        Console.WriteLine($"Aluna: {nome} | Curso: {curso}");
        Console.WriteLine($"Saldo Inicial: R$ {saldoBancario}");


        // ============================================================
        // 2. ENTRADA, SAÍDA E CONVERSÃO (Baseado no Slide 11)
        // ============================================================
        Console.WriteLine("\n--- Testando Entrada de Dados ---");

        // Console.Write: Escreve e mantem o cursor na mesma linha
        Console.Write("Digite quanto você quer depositar: ");

        // Console.ReadLine: Lê o que o usuário digitou SEMPRE como TEXTO (string)
        string textoDigitado = Console.ReadLine();

        // Parse: Converte o texto para número para podermos fazer contas
        decimal valorDeposito = decimal.Parse(textoDigitado);


        // ============================================================
        // 3. OPERADORES MATEMÁTICOS (Baseado no Slide 12)
        // ============================================================

        // Soma (+)
        saldoBancario = saldoBancario + valorDeposito;

        // Incremento (++): Aumenta 1 no valor atual
        idade++;

        Console.WriteLine("\n--- Resultados Finais ---");
        Console.WriteLine($"Idade atualizada (aniversário): {idade} anos");
        Console.WriteLine($"Novo Saldo: R$ {saldoBancario}");

        // Operador Modulo (%): Resto da divisão (muito usado para saber se é par/ímpar)
        // Exemplo: Se o resto da divisão por 2 for 0, é par.
        int resto = idade % 2;
        Console.WriteLine($"O resto da divisão da idade por 2 é: {resto}");
    }
}