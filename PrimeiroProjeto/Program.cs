// screen sound

string mensagemBoasVindas = "Boas Vindas ao Screen Sound!";
//List<string> bandas = new List<string>();

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("Linkin Park", new List<int> { 10, 8, 9, 10});
bandas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"


░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemBoasVindas);
    
}

void ExibirOpcoesDoMenu ()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMedia();
            break;
        case -1: Console.WriteLine("Tchau Tchau :)");
            break;
        default: Console.WriteLine("Opção Inválida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulos("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTitulos("Exibindo todas as Bandas registradas");
    //for (int i = 0; i < bandas.Count; i++)
    // {
    //Console.WriteLine($"Banda: {bandas[i]}");
    //}
    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTitulos( string titulos )
{
    int qtdLetras = titulos.Length;
    string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulos);
    Console.WriteLine(asteriscos + "\n");
}


void AvaliarUmaBanda()
    {
    //digite qual banda deseja avalidar

    //se a banda existir >> atribuir uma nota

    //senão, volta ao menu principal

    Console.Clear();
    ExibirTitulos("Avaliar Bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia()
    {
    Console.Clear();
    ExibirTitulos("Exibir Média da Banda");
    Console.Write("Digite o nome da banda que deseja ver a média de avaliações: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandas.ContainsKey (nomeDaBanda))
    {
        List<int> notasDaBanda = bandas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();







//gabrielly colman