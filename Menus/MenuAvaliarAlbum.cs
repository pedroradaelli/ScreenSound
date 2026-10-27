

using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome da banda que contem o album: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;

            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
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
                    album.AdicionarNota(nota);

                    Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Thread.Sleep(1000);
                    Console.Clear();


                }

            } else
            {
                Console.WriteLine($"O álbun {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Thread.Sleep(1000);
                Console.Clear();
            }

        }
        else
        {
            Console.WriteLine($"\nA Banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Thread.Sleep(1000);
            Console.Clear();

        }

    }
}

