

using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarMusicas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar musica");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaMusica = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaMusica))
        {
            Banda banda = bandasRegistradas[nomeDaMusica];

            Console.Write($"Qual a nota a musica {nomeDaMusica} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);

            if (nota.Nota > 5)
            {
                Console.WriteLine("Nota invalida!");
                Console.WriteLine("Digite um numero entre 0 e 5 ");
                Console.WriteLine("\nDigite qualquer tecla para reiniciar a página");
                Console.ReadLine();

            }
            else
            {
                banda.AdicionarNota(nota);

                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a musica {nomeDaMusica}");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Thread.Sleep(1000);
                Console.Clear();


            }

        }
        else
        {
            Console.WriteLine($"\nA Musica {nomeDaMusica} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Thread.Sleep(1000);
            Console.Clear();

        }
    }
}
