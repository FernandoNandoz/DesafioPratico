namespace DesafioPratico;

internal class Exercicio03
{
    public static void Exercicio()
    {
        Console.WriteLine("\n=============================================================\n");

        Console.WriteLine("Ola seja bem vindo ao Vamos fazer algumas contas agora!!" + "\n");

        Console.WriteLine("Sem perca de tempo, vamos ao que interressa... \n");

        double valor1 = 10.5;
        double valor2 = 20.5;

        Console.WriteLine("Temos o valor 1 " + valor1 + "\n");

        Console.WriteLine("\n" + "E temos o valor 2 " + valor2 + "\n");

        var soma = Soma(valor1, valor2).status + Soma(valor1, valor2).resultado;
        Console.WriteLine(soma);

        Console.WriteLine("");

        var subtracao = Subtracao(valor1, valor2).status + Subtracao(valor1, valor2).resultado;
        Console.WriteLine(subtracao);

        Console.WriteLine("");

        var multiplicacao = Multiplicacao(valor1, valor2).status + Multiplicacao(valor1, valor2).resultado;
        Console.WriteLine(multiplicacao);

        Console.WriteLine("");

        var divisao = Divisao(valor1, valor2).status + Divisao(valor1, valor2).resultado;
        Console.WriteLine(divisao);

        Console.WriteLine("");

        var media = Media(valor1, valor2).status + Media(valor1, valor2).resultado;
        Console.WriteLine(media);



        Console.WriteLine("\n \nBye bye......");
    }

    static (string status, double resultado) Soma(double valor1, double valor2)
    {
        var resultado = valor1 + valor2;

        return ("Soma dos valores é: ", resultado);
    }

    static (string status, double resultado) Subtracao(double valor1, double valor2)
    {
        var resultado = valor1 - valor2;

        return ("Subtração dos valores é: ", resultado);
    }

    static (string status, double resultado) Multiplicacao(double valor1, double valor2)
    {
        var resultado = valor1 * valor2;

        return ("Multiplicação dos valores é: ", resultado);
    }

    static (string status, double resultado) Divisao(double valor1, double valor2)
    {
        var resultado = valor1 / valor2;

        if (valor2 == 0)
        {
            return ("Opaa!! Não é possivel dividir por zero...", resultado);
        }
        else
        {
            return ("Divisão dos valores é: ", resultado);
        }
    }

    static (string status, double resultado) Media(double valor1, double valor2)
    {
        var resultado = (valor1 + valor2) / 2;

        return ("Média dos valores é: ", resultado);
    }
}
