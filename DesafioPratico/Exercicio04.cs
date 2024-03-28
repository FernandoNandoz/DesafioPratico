namespace DesafioPratico;
internal class Exercicio04
{
    public static void Exercicio()
    {
        Console.WriteLine("\n=============================================================\n");

        Console.WriteLine("Ola seja bem vindo ao Vamos contar caracteres?" + "\n");

        Console.WriteLine("Sem perca de tempo, vamos ao que interressa... \n");

        Console.WriteLine("Digite uma ou mais palavras e descubra quantos caracteres ela possui: ");

        string palavra = Console.ReadLine();

        int quantidadeCaracteres = 0;

        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] != ' ')
            {
                quantidadeCaracteres++;
            }
        }
        

        Console.WriteLine("\n" + "Quantidade de caracteres nesta palavra: " + quantidadeCaracteres);

    }
}
