using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPratico;
internal class Exercicio05
{
    public static void Exercicio()
    {
        Console.WriteLine("\n=============================================================\n");

        Console.WriteLine("Ola seja bem vindo ao Verifique se a placa do seu veiculo é valida" + "\n");

        Console.WriteLine("Sem perca de tempo, vamos ao que interressa... \n");

        Console.WriteLine("Este programa verifica se a placa do veículo informada é valida" + "\n" + "baseada no padrão brasileiro válido até 2018." + "\n");

        Console.Write("Informe a placa de um veiculo: ");
        var placaVeiculo = Console.ReadLine();

        Console.Write("\n");

        var placaValida = VerificarPlaca(placaVeiculo);

        if (placaValida)
        {
            Console.WriteLine("Está placa é Verdadeira!");
        }
        else
        {
            Console.WriteLine("Está placa é Falsa!");
        }


        Console.WriteLine("\n\n" + "Bye bye");
    }

    static bool VerificarPlaca(string placaVeiculo)
    {
        int caracteresAlfanumericos = 0;
        int caracteresLetra = 0;
        int caracteresNumericos = 0;

        for (int i = 0; i < placaVeiculo.Length; i++)
        {
            if (placaVeiculo[i] != ' ')
            {
                caracteresAlfanumericos++;
            }

            // Verifica se os 3 primeiros caracteres são letras 
            if (i < 3)
            {
                if (char.IsLetter(placaVeiculo[i]))
                {
                    caracteresLetra++;
                }
            }
            else // Verifica se os ultimos caracteres são numeros 
            {
                if (char.IsDigit(placaVeiculo[i]))
                {
                    caracteresNumericos++;
                }
            }
            
        }

        if (caracteresAlfanumericos == 7 && caracteresLetra == 3 && caracteresNumericos == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
