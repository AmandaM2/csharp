using System; //  Importando bibliotecas básicas

class Program
{
    static void Main() 
    {
        Console.WriteLine("=== AULA 01: FUNDAMENTOS E VARIÁVEIS ===");

        // ============================================================
        // 1. TIPOS DE DADOS E VARIÁVEIS 
        // ============================================================

        // Números Inteiros 
        int idade = 22;              // 'int' é o padrão para números sem vírgula
        long populacaoMundial = 8000000000; // 'long' é para números gigantes

        // Números Decimais 
        double altura = 1.75;        // 'double' é o padrão para decimais
        float peso = 70.5f;          // 'float' precisa do 'f' no final (menos preciso)
        decimal saldoBancario = 1500.99m; // 'decimal' precisa do 'm'. OBRIGATÓRIO para dinheiro!

        // Texto e Caracteres 
        char inicial = 'A';          // 'char' usa aspas simples (um caractere só)
        string nome = "Amanda";      // 'string' usa aspas duplas (texto)

        // Lógica 
        bool estaEstudando = true;   // 'bool' só aceita true (verdadeiro) ou false (falso)

        // Inferência de Tipo 
        var curso = "Engenharia de Software"; // O C# descobre sozinho que é string

        Console.WriteLine($"Aluna: {nome} | Curso: {curso}");
        Console.WriteLine($"Saldo Inicial: R$ {saldoBancario}");


        // ============================================================
        // 2. ENTRADA, SAÍDA E CONVERSÃO 
        // ============================================================
        Console.WriteLine("\n--- Testando Entrada de Dados ---");

        // Console.Write: Escreve e mantem o cursor na mesma linha
        Console.Write("Digite quanto você quer depositar: ");

        // Console.ReadLine: Lê o que o usuário digitou SEMPRE como TEXTO (string)
        string textoDigitado = Console.ReadLine();

        // Parse: Converte o texto para número para podermos fazer contas
        decimal valorDeposito = decimal.Parse(textoDigitado);


        // ============================================================
        // 3. OPERADORES MATEMÁTICOS 
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

        // ==========================================================
        // 4. ESTRUTURAS DE REPETIÇÃO (FOR)
        // ==========================================================
        Console.WriteLine("\n--- Loop FOR (Para percorrer listas) ---");

        // Primeiro, criamos uma lista para testar
        List<string> listaDasBandas = new List<string> { "Pink Floyd", "Led Zeppelin", "Beatles" };

        // SINTAXE DO FOR: (INICIO ; CONDIÇÃO ; PASSO)
        // 1. int i = 0  -> Começa o contador no zero (primeira posição)
        // 2. i < lista.Count -> Continua enquanto o contador for menor que o tamanho da lista
        // 3. i++        -> Aumenta 1 no contador a cada volta

        for (int i = 0; i < listaDasBandas.Count; i++)
        {
            Console.WriteLine($"Banda na posição {i}: {listaDasBandas[i]}");
        }

        // ==========================================================
        // 5. ERROS COMUNS (TIPAGEM FORTE)
        // ==========================================================
        // ATENÇÃO: Nunca compare tipos diferentes (Número vs Texto)

        int nota = 6;
        string musica = "Yesterday";

        // ERRADO: if (nota <= "6") 
        // O erro será: "Operator '<=' cannot be applied to operands of type 'int' and 'string'"

        // CORRETO: Remova as aspas para comparar número com número
        if (nota <= 6)
        {
            Console.WriteLine(musica + " -> essa música não é tão boa");
        }
        else
        {
            Console.WriteLine(musica + " -> essa música é ótima");
        }

        // ==========================================================
        // 6. LOOP FOREACH (PARA CADA...)
        // ==========================================================
        Console.WriteLine("\n--- Loop FOREACH (Mais simples) ---");

        // Tradução: "Para Cada (string banda) dentro da (listaDasBandas)"
        // Ele pega o primeiro item, joga na variável 'banda', executa o bloco, e repete.

        foreach (string banda in listaDasBandas)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        // ==========================================================
        // RESUMO: QUAL USAR?
        // ==========================================================
        // FOR: Use quando precisar do índice (i).
        // Ex: "Quero alterar a banda número 2" ou "Quero pular de 2 em 2".

        // FOREACH: Use quando quiser ler a lista toda do início ao fim.
        // Ex: "Quero mostrar tudo na tela". É mais fácil de ler e escrever.
    }
}