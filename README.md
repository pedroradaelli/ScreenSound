🎶 ScreenSound

Aplicação de console em C#. 

Desenvolvi o projeto enquanto estudava orientação a objetos com C#, o projeto foi uma forma de consolidar meus estudos e botar em prática o que aprendi

Funcionalidades

Registrar Bandas/Álbuns 

Ver Bandas registradas

Ver Álbuns registrados

Ver Detalhes da Banda e Álbuns



Estrutura

Program.cs - Principal arquivo, executa o programa

Pasta Modelos:
Album.cs / Avaliacao.cs / Banda.cs / Musica.cs / IAvaliacao.cs(Interface) / IEnumerable
Todas as classes conversam entre si.
A pasta Modelos armazena as classes citadas acima, assim garantindo maior organização no projeto


Pasta Menus: Menu.cs / MenuAvaliarAlbun.cs / MenuAvaliarUmaBanda.cs / MenuAvaliarMusica.cs / MenuExibirDetalhes.cs / MenuMostrarBandasRegistradas.cs / MenuRegistrarAlbum.cs / MenuRegistrarBanda.cs

A pasta Menus armazena as classes citadas acima, assim garantindo maior organização no projeto



Requer .NET 6+.

bash dotnet run

Os dados ficam apenas na memória e são perdidos ao fechar o programa.# ScreenSound
