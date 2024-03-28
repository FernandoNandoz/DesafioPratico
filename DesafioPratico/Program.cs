namespace DesafioPratico;

class Program()
{
    static void Main()
    {
        Console.WriteLine("Olaa tudo bem!!!" + "\n");

        Console.WriteLine("Olha só, escolha e informe o numero de uma das opções abaixo e veja a magia acontecer..... "+ "\n");

        Console.WriteLine("1 - Receba boas vindas de mim!");
        Console.WriteLine("2 - Veja a magia da concatenação...");
        Console.WriteLine("3 - Vamos fazer algumas contas agora");
        Console.WriteLine("4 - Vamos contar caracteres?");
        Console.WriteLine("5 - Verifique se a placa do seu veiculo é valida");
        Console.WriteLine("6 - Que dia é hoje? Vamos ver as Data....");

        Console.Write("\n" + "Informe apenas o numero referente a sua escolha: ");
        var escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Exercicio01.Exercicio();
                break;
            case "2":
                Exercicio02.Exercicio();
                break;
            case "3":
                Exercicio03.Exercicio();
                break;
            case "4":
                Exercicio04.Exercicio();
                break;
            case "5":
                Exercicio05.Exercicio();
                break;
            case "6":
                Exercicio06.Exercicio();
                break;
            default: 
                Console.WriteLine("Opiis!!  Acho que você não informou a opção correta...." + "\n" + "Tente novamente e dessa vez digite um numero de uma das 6 opções acima.");
                break;
        };
    }
}
