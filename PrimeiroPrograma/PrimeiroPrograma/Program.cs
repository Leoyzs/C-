//Screen Sound

Dictionary<string, List<int>> BandasRegistradas = new Dictionary<string, List<int>>();
// dicionario, nome da banda é o ID e a lista as notas.
BandasRegistradas.Add("Nirvana", new List<int> {10,8,6});
BandasRegistradas.Add("Linkin Park", new List<int> {10,10,10});

ExibirOpcoesDoMenu();

void ExibirTituloDaOperação(string Titulo)
{
    int quantidadeDeLetras = Titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');   
    Console.WriteLine(asteriscos);
    Console.WriteLine(Titulo);
    Console.WriteLine(asteriscos + "\n");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.Write("\nDigite 1 para Registrar banda \nDigite 2 para mostrar todas as bandas\nDigite 3 para avaliar uma banda\nDigite 4 para exibir a média de uma banda\nDigite -1 para sair\n\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInteira = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaInteira)
    {
        case 1: RegistrarBandas(); break;
        case 2: MostrarTodasAsBandas(); break;
        case 3: AvaliarBanda(); break;
        case 4: MediaNotas(); break;
        case -1: Console.WriteLine("Finalizando programa"); break;
        default: Console.WriteLine("Opcao escolhida invalida"); break;
    }
}

void ExibirLogo()
{
    Console.WriteLine(@"
░█▀▀▀█ █▀▀ █▀▀█ █▀▀ █▀▀ █▀▀▄ 　 ░█▀▀▀█ █▀▀█ █──█ █▀▀▄ █▀▀▄ 
─▀▀▀▄▄ █── █▄▄▀ █▀▀ █▀▀ █──█ 　 ─▀▀▀▄▄ █──█ █──█ █──█ █──█ 
░█▄▄▄█ ▀▀▀ ▀─▀▀ ▀▀▀ ▀▀▀ ▀──▀ 　 ░█▄▄▄█ ▀▀▀▀ ─▀▀▀ ▀──▀ ▀▀▀─");
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOperação("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string NomeBandaRegistrada = Console.ReadLine()!;
    BandasRegistradas.Add(NomeBandaRegistrada, new List<int>());
    Console.WriteLine("Banda: " + NomeBandaRegistrada);
    Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial");
    Console.ReadKey(); Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    Console.Clear() ;   
    ExibirTituloDaOperação("Avaliar Banda");
    Console.WriteLine("Digite a banda q deseja avaliar dentro as opções abaixo: ");
    foreach (String Bandas in BandasRegistradas.Keys)
    {
        Console.WriteLine(Bandas);
    }

    String nomeDaBanda = Console.ReadLine()!;
    if(BandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda: {nomeDaBanda} Merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        BandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine("A nota: " + nota + " foi registrada com sucesso\nPressione qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine("Banda nao existe\nDigite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
}

void MostrarTodasAsBandas()
{
    Console.Clear();
    ExibirTituloDaOperação("Exibindo todas as bandas");

    if (BandasRegistradas.Count == 0)
    {
        Console.WriteLine("Nenhuma banda registrada.");
    }
    else
    {
        foreach (string banda in BandasRegistradas.Keys)
        {
            Console.WriteLine("A banda registrada foi: " + banda);

            // Para cada banda, percorremos as notas associadas
            List<int> notas = BandasRegistradas[banda]; // Pegamos a lista de notas associada à banda

            foreach (int nota in notas) // Percorremos as notas da banda
            {
                Console.WriteLine("Nota: " + nota);
            }
        }


        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MediaNotas()
{
    Console.WriteLine("Digite qual banda voce deseja ver a media dentro das opções abaixo: ");
    foreach (String Bandas in BandasRegistradas.Keys)
    {
        Console.WriteLine(Bandas);
    }
    String NomeBanda = Console.ReadLine();
    List<int> NotasMedia = BandasRegistradas[NomeBanda];
    if(BandasRegistradas.ContainsKey(NomeBanda))
    {
        double MediaDasNotasDaBanda = NotasMedia.Average();
        Console.WriteLine($"A media da nota de banda: {NomeBanda} é: " + MediaDasNotasDaBanda);
        Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial");
        Console.ReadKey(); Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("ERROR: Nome da banda invalido;\nPressione qualquer tecla para voltar ao menu inicial");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}


