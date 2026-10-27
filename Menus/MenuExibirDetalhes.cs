using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            

            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine("Discografia: ");
            foreach(Album albun in banda.Albuns)
            {
                if(albun.Media >= 4)
                {
                    Console.WriteLine($"O Álbun: {albun.Nome}, tem uma média de avaliação muito boa: {albun.Media}");
                }
                else if (albun.Media == 3)
                {
                    
                    Console.WriteLine($"O Álbun: {albun.Nome}, tem uma média de avaliação boa: {albun.Media}");
                    
                }
                else if (albun.Media <= 2)
                {

                    Console.WriteLine($"O Álbun: {albun.Nome}, tem uma média de avaliação ruim: {albun.Media}");

                }


            }
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Thread.Sleep(1000);
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
