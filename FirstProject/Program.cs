Dictionary<string, List<int>> jogoRegistrado = new Dictionary<string, List<int>>();
jogoRegistrado.Add("Skyrim", new List<int> { 10, 9, 3 });
jogoRegistrado.Add("Counter-Strike", new List<int> { 8, 6, 6 });
jogoRegistrado.Add("Cyberpunk 2077", new List<int>());
jogoRegistrado.Add("Baldur's Gate 3", new List<int> { 9 });
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗████████╗███████╗░█████╗░███╗░░░███╗    ██╗░░░██╗███████╗██████╗░███╗░░░███╗███████╗██╗░░░░░██╗░░██╗░█████╗░
██╔════╝╚══██╔══╝██╔════╝██╔══██╗████╗░████║    ██║░░░██║██╔════╝██╔══██╗████╗░████║██╔════╝██║░░░░░██║░░██║██╔══██╗
╚█████╗░░░░██║░░░█████╗░░███████║██╔████╔██║    ╚██╗░██╔╝█████╗░░██████╔╝██╔████╔██║█████╗░░██║░░░░░███████║███████║
░╚═══██╗░░░██║░░░██╔══╝░░██╔══██║██║╚██╔╝██║    ░╚████╔╝░██╔══╝░░██╔══██╗██║╚██╔╝██║██╔══╝░░██║░░░░░██╔══██║██╔══██║
██████╔╝░░░██║░░░███████╗██║░░██║██║░╚═╝░██║    ░░╚██╔╝░░███████╗██║░░██║██║░╚═╝░██║███████╗███████╗██║░░██║██║░░██║
╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝    ░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝
");
}
void ExibirOpcoesDoMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\n1. Registrar Jogo");
    Console.WriteLine("\n2. Listar Jogos");
    Console.WriteLine("\n3. Avaliar Jogo");
    Console.WriteLine("\n4. Média dos Jogos");
    Console.WriteLine("\n5. Sair");
    Console.Write("\nSelecionar Opção : ");
    string opcaoEscolhidaMenu = Console.ReadLine()!;
    switch (int.Parse(opcaoEscolhidaMenu))
    {
        case 1:
            RegistrarJogo();
            break;
        case 2:
            MostrarRegistroDeJogos();
            break;
        case 3:
            AvaliacaoDeJogos();
            break;
        case 4:
            MediaDosJogos();
            break;
        case 5:
            Console.WriteLine("Você escolheu sair, até a proxima!");
            break;
        default:
            Console.WriteLine("Opção Invalida");
            break;
    }
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras + 2, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(" " + titulo);
    Console.WriteLine(asteriscos + "\n");
}
void RegistrarJogo()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Jogos");
    Console.Write("Digite o nome de uma Jogo :");
    string nomeDoJogo = Console.ReadLine()!;
    jogoRegistrado.Add(nomeDoJogo, new List<int>());
    Console.WriteLine(nomeDoJogo + " foi registrado com sucesso!");
    Console.WriteLine("\nPressione '1' para Registrar outro Jogo");
    Console.WriteLine("\nPressione '2' para Voltar");
    string opcaoEscolhidaReg = Console.ReadLine()!;
    switch (int.Parse(opcaoEscolhidaReg))
    {
        case 1:
            RegistrarJogo();
            break;
        case 2:
            ExibirOpcoesDoMenu();
            break;
        default:
            Console.WriteLine("Opção Invalida");
            break;
    }
    ExibirOpcoesDoMenu();
}
void MostrarRegistroDeJogos()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista de Jogos");
    foreach (string jogo in jogoRegistrado.Keys)
    {
        Console.WriteLine(jogo);
    }
    Console.WriteLine("\nPressione '1' para Voltar");
    string opcaoEscolhidaMedia = Console.ReadLine()!;
    switch (int.Parse(opcaoEscolhidaMedia))
    {
        case 1:
            MediaDosJogos();
            break;
        case 2:
            ExibirOpcoesDoMenu();
            break;
        default:
            Console.WriteLine("Opção Invalida");
            break;
    }
    ExibirOpcoesDoMenu();
}
void AvaliacaoDeJogos()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Jogo");
    Console.Write("Selecione um Jogo :");
    string nomeDoJogo = Console.ReadLine()!;
    if (jogoRegistrado.ContainsKey(nomeDoJogo))
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avalie " + nomeDoJogo);
        Console.Write("De uma nota de 1 ~ 5 :");
        int nota = int.Parse(Console.ReadLine()!);
        jogoRegistrado[nomeDoJogo].Add(nota);
        Console.WriteLine("\nPressione '1' para Avaliar outro Jogo");
        Console.WriteLine("\nPressione '2' para Voltar");
        string opcaoEscolhidaAval2 = Console.ReadLine()!;
        switch (int.Parse(opcaoEscolhidaAval2))
        {
            case 1:
                AvaliacaoDeJogos();
                break;
            case 2:
                ExibirOpcoesDoMenu();
                break;
            default:
                Console.WriteLine("Opção Invalida");
                break;
        }
    }
    else
    {
        Console.WriteLine("O " + nomeDoJogo + " não foi encotrado");
        Console.WriteLine("\nPressione '1' para Tentar Novamente");
        Console.WriteLine("\nPressione '2' para Voltar");
        Console.ReadKey();
        string opcaoEscolhidaAval3 = Console.ReadLine()!;
        switch (int.Parse(opcaoEscolhidaAval3))
        {
            case 1:
                AvaliacaoDeJogos();
                break;
            case 2:
                ExibirOpcoesDoMenu();
                break;
            default:
                Console.WriteLine("Opção Invalida");
                break;
        }
    }
    ExibirOpcoesDoMenu();
}
void MediaDosJogos()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média dos Jogos");
    Console.Write("Escolha um jogo:");
    string nomeDoJogo = Console.ReadLine()!;
    if (jogoRegistrado.ContainsKey(nomeDoJogo))
    {
        Console.Clear();
        ExibirTituloDaOpcao("Média dos Jogos");
        double media = jogoRegistrado[nomeDoJogo].Average();
        Console.WriteLine();
        Console.WriteLine("\nPressione '1' para Ver a Média de outro Jogo");
        Console.WriteLine("\nPressione '2' para Voltar");
        string opcaoEscolhidaMedia = Console.ReadLine()!;
        switch (int.Parse(opcaoEscolhidaMedia))
        {
            case 1:
                MediaDosJogos();
                break;
            case 2:
                ExibirOpcoesDoMenu();
                break;
            default:
                Console.WriteLine("Opção Invalida");
                break;
        }
    }
    else
    {
        Console.WriteLine("O " + nomeDoJogo + " não foi encotrado");
        Console.WriteLine("\nPressione '1' para Tentar Novamente");
        Console.WriteLine("\nPressione '2' para Voltar");
        string opcaoEscolhidaMedia = Console.ReadLine()!;
        switch (int.Parse(opcaoEscolhidaMedia))
        {
            case 1:
                MediaDosJogos();
                break;
            case 2:
                ExibirOpcoesDoMenu();
                break;
            default:
                Console.WriteLine("Opção Invalida");
                break;
        }
    }
    ExibirOpcoesDoMenu();
}
ExibirOpcoesDoMenu();