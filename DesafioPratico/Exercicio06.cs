using System.Globalization;

namespace DesafioPratico;
internal class Exercicio06
{
    public static void Exercicio()
    {
        Console.WriteLine("\n=============================================================\n");

        Console.WriteLine("Ola seja bem vindo ao Que dia é hoje? Vamos ver as Data...." + "\n");

        Console.WriteLine("Sem perca de tempo, vamos ao que interressa... \n");

        Console.WriteLine("Hoje é dia: " + DateTime.Now.ToShortDateString() + " Ou mas especificamente.... \n");

        DateTime dataAtual = DateTime.Now;

        var dataCompleta = dataAtual.ToString("F", new CultureInfo("pt-BR"));
        var dataFormatoBrasilAbreviada = dataAtual.ToString("d", new CultureInfo("pt-BR"));
        var horario = dataAtual.ToString("HH", new CultureInfo("pt-BR"));
        var dataMesPorExtenso = dataAtual.ToString("d MMMM yyyy", new CultureInfo("pt-BR"));

        Console.WriteLine(dataCompleta);
        Console.WriteLine(dataFormatoBrasilAbreviada);
        Console.WriteLine(horario + "horas");
        Console.WriteLine(dataMesPorExtenso);

        Console.WriteLine("\n\n\nBye bye");
    }
}
