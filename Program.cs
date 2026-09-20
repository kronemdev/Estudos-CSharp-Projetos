double saldo = 5000;
int opcao = 0;

while (opcao != 4)
{
    Console.WriteLine("\n--- CAIXA ELETRÔNICO ---");
    Console.WriteLine("1 - Ver Saldo");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha Uma Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Seu saldo atual é R$ {saldo}");
            break;
        case 2:
            Console.WriteLine("Digite o Valor do Depósito : R$");
            double valorDeposito = double.Parse(Console.ReadLine());
            saldo += valorDeposito;
            Console.WriteLine("Depósito Realizado com Sucesso!");
            break;
        case 3:
            Console.WriteLine("Digite o valor do Saque: ");
            double saque = double.Parse(Console.ReadLine());
            if (saque > saldo)
            {
                Console.WriteLine($"Erro! Saldo insulficiente! Você tem apenas R$ {saldo}");
            }
            else
            {
                saldo -= saque;
                Console.WriteLine("Saque Realizado com Sucesso!");
                Console.WriteLine($"Saldo atual é : {saldo}");
            }
            break;

        case 4:
            Console.WriteLine("Obrigado por usar o nosso Banco. Até logo!");
            break;

    }
}

