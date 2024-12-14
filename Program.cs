void Soma()
{
    Console.Clear();
    Console.WriteLine("Primerio valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da soma é: {v1 + v2}");
    Console.WriteLine("Deseja ir ao menu? (s/n)");
    string opcao = Console.ReadLine();

    if (opcao == "s")
    {
        Menu();
    }
}

void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Primerio valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da soma é: {v1 - v2}");
    Console.WriteLine("Deseja ir ao menu? (s/n)");
    string opcao = Console.ReadLine();

    if (opcao == "s")
    {
        Menu();
    }
}

void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Primerio valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da soma é: {v1 * v2}");
    Console.WriteLine("Deseja ir ao menu? (s/n)");
    string opcao = Console.ReadLine();

    if (opcao == "s")
    {
        Menu();
    }
}

void Divisao()
{
    Console.Clear();
    Console.WriteLine("Primerio valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da soma é: {v1 / v2}");
    Console.WriteLine("Deseja ir ao menu? (s/n)");
    string opcao = Console.ReadLine();

    if (opcao == "s")
    {
        Menu();
    }
}

void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("-----------------");
    Console.WriteLine("Selecione uma opção: ");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1:
            Soma();
            break;
        case 2:
            Subtracao();
            break;
        case 3:
            Divisao();
            break;
        case 4:
            Multiplicacao();
            break;
        case 5:
            System.Environment.Exit(0);
            break;
        default:
            Menu();
            break;
    }
}

Menu();