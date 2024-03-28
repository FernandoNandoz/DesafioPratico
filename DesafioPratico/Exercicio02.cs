using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPratico;
internal class Exercicio02
{
    public static void Exercicio()
    {
        string? nome = "Fernando";
        string? sobrenome = "Souza";

        Console.WriteLine("\n=============================================================\n");

        Console.WriteLine("Ola seja bem vindo a Magia da Concatenação!!");
        Console.WriteLine("Quero te mostrar uma coisa: \n");

        Console.Write("Digite seu primeiro nome: ");
        nome = Console.ReadLine();

        Console.Write("\n" + "Agora digite seu sobrenome: ");
        sobrenome = Console.ReadLine();

        Console.WriteLine("\n" + "Perfeito!!!!!" + "\n");

        Console.WriteLine("Seu primeiro nome: " + nome);
        Console.WriteLine("Seu sobrenome: " + sobrenome);

        Console.WriteLine("\n" + "Veja só... Estão separados né!? \n");

        Console.WriteLine("Agora vou junta-los....");

        Console.WriteLine("\n...................... \n");

        Console.WriteLine(nome + " " + sobrenome);

        Console.WriteLine("\n...................... \n");

        Console.WriteLine("Viu só! Bacana né....");

        Console.WriteLine("\nAté mais!!!");
    }
}
