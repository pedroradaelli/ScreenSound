using ScreenSound;
using ScreenSound.Menus;
using ScreenSound.Modelos;

//Cria uma nova Banda chamada Ira
Banda ira = new("Ira");

//Cria uma nova Banda chamada The Beatles
Banda Beatles = new("The Beatles");

//Um dicionario que armazena o nome das bandas (praticamente tudo depende dele)
Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(Beatles.Nome, Beatles);


Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuAvaliarUmaBanda());
opcoes.Add(3, new MenuRegistrarAlbum());
opcoes.Add(4, new MenuAvaliarAlbum());
opcoes.Add(5, new MenuMostrarBandasRegistradas());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

//exibe a logo da aplicação
void ExibirLogo()
{
    Console.Clear();
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}




//Exibe as opções existentes pro usuario, verifica se o dicionario opcoes contem o numero digitado 
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para avaliar uma banda");
    Console.WriteLine("Digite 3 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 4 para avaliar um álbum");
    Console.WriteLine("Digite 5 para mostrar todas as bandas");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {

        Menu menu = opcoes[opcaoEscolhidaNumerica];
        menu.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();

    } 
    else
    {
        Console.WriteLine("Opção inválida");

    }
}

ExibirOpcoesDoMenu();