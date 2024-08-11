using System;

public class HelloWorld
{
    // Variáveis para controlar o estado da aplicação
    static bool ContaLogada = false;
    static float Saldo = 0;  // Variável de instância para armazenar o saldo

    public static void Main(string[] args)
    {
        int i = 0;  // Inicializando a variável de controle do loop

        while (i != 1)  // Loop continuará até que o usuário escolha sair (i == 1)
        {

            // Leitura do que o usuário deseja no aplicativo.
            Console.WriteLine("Digite 1 para sair da tela ou qualquer outra tecla para continuar!");
            string inputI = Console.ReadLine();

            if (int.Parse(inputI) == 1)
            {
                i = 1;  // Define i como 1 para sair do loop
            }
            else
            {
                // Verifica se a conta está logada
                if (ContaLogada)
                {
                    Console.WriteLine("Qual transacao deseja realizar \nDigite 1 para Sacar \nDigite 2 para Depositar \nDigite 3 para sair do aplicativo");

                    // Switch para definir o que o usuário deseja
                    string inputTransacaoDesejada = Console.ReadLine();
                    int transacao = int.Parse(inputTransacaoDesejada);

                    switch (transacao)
                    {
                        case 1:
                            Console.WriteLine("Digite o valor a ser sacado");
                            string inputSaque = Console.ReadLine();
                            float valorSacado = float.Parse(inputSaque);
                            Saldo -= valorSacado;
                            Console.WriteLine("Sacado com sucesso! Seu novo saldo: " + Saldo + " e foi sacado:" + valorSacado);
                            break;
                        case 2:
                            Console.WriteLine("Quanto deseja depositar?");
                            string inputDeposito = Console.ReadLine();
                            float valorDeposito = float.Parse(inputDeposito);
                            Saldo += valorDeposito;
                            Console.WriteLine("Depositado com sucesso! Seu novo saldo: " + Saldo);
                            break;
                        case 3:
                            i = 1;  // Sair do loop
                            break;
                        default:
                            Console.WriteLine("Comando inválido");
                            break;
                    }
                }
                else
                {
                    EntrarNaConta();  // Chama o método para entrar na conta
                    Console.Clear();
                }
            }
        }
        Console.WriteLine("Obrigado por usar nosso banco!!");
    }

    // Método para logar na conta
    static void EntrarNaConta()
    {
        Console.WriteLine("Digite o numero da conta:");
        string inputConta = Console.ReadLine();
        int conta = int.Parse(inputConta);

        Console.WriteLine("Digite o digito da conta:");
        string inputDigito = Console.ReadLine();
        int digito = int.Parse(inputDigito);

        Console.WriteLine("Digite sua senha:");
        string inputSenha = Console.ReadLine();
        int senha = int.Parse(inputSenha);

        Console.WriteLine("Digite seu saldo inicial:");
        string inputSaldo = Console.ReadLine();
        Saldo = float.Parse(inputSaldo);  // Agora a variável Saldo é acessível aqui

        ContaLogada = true;
        Console.WriteLine("Conta logada com sucesso!");
    }

    // Método para registrar conta (futuramente implementado)
    static void RegistrarConta()
    {
        // Implementação futura
    }
}
