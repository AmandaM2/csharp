
using System;

class Program
{
    static void Main()
    {
        // =============================================================
        // DESAFIO: SISTEMA DE PAGAMENTO DE DÍVIDAS
        // Objetivo: Simular o pagamento e calcular troco ou saldo devedor.
        // =============================================================

        Console.WriteLine("--- Sistema de Cobrança ---");

        // 1. DEFINIÇÃO DA DÍVIDA
        // Usamos o tipo 'decimal' para valores monetários.
        // Por que não 'double'? O 'double' pode ter pequenos erros de arredondamento.
        // O 'decimal' é preciso. O sufixo 'm' avisa ao C# que esse número é dinheiro.
        decimal dividaTotal = 5000.00m;

        // 2. ENTRADA DE DADOS (O que o usuário digita)
        Console.Write("Digite o seu nome: ");
        string nomeCliente = Console.ReadLine(); // O cursor fica na mesma linha (Write)

        Console.Write("Qual valor você deseja pagar hoje? R$ ");
        string textoDigitado = Console.ReadLine(); // Lê a entrada como TEXTO (string)

        // 3. CONVERSÃO (Parsing)
        // O computador não sabe somar texto ("500" + "500" daria "500500").
        // Precisamos converter o texto para número decimal para fazer matemática.
        decimal valorPago = decimal.Parse(textoDigitado);

        Console.WriteLine("\n--------------------------------");
        Console.WriteLine($"Cliente: {nomeCliente}"); // O $ permite colocar variáveis dentro do texto

        // 4. LÓGICA DE DECISÃO (O coração do programa)
        // O 'if' cria uma bifurcação no código. Ou vai para um lado, ou para o outro.


        // CENÁRIO A: O cliente pagou a dívida toda (ou até mais)
        if (valorPago >= dividaTotal)
        {
            Console.WriteLine("SITUAÇÃO: Dívida QUITADA com sucesso! ✅");

            // Verificação extra: Sobrou troco?
            if (valorPago > dividaTotal)
            {
                // Subtraímos o total da dívida do valor que ele deu
                decimal troco = valorPago - dividaTotal;
                Console.WriteLine($"Seu troco é de: R$ {troco}");
            }
        }
        // CENÁRIO B: O cliente pagou menos do que devia
        else
        {
            // Calculamos quanto ainda falta (Dívida Total - O que ele pagou)
            decimal faltaPagar = dividaTotal - valorPago;

            Console.WriteLine("SITUAÇÃO: Pagamento Parcial recebido. ⚠️");
            Console.WriteLine($"Valor abatido: R$ {valorPago}");
            Console.WriteLine($"Ainda falta pagar: R$ {faltaPagar}");
        }

        Console.WriteLine("--------------------------------");
    }
}