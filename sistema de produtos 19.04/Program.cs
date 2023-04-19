// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

string[] produtosNome = new string[2];

float[] produtosPreco = new float[2];

bool[] produtosPromocao = new bool[2];

char[] produtosPromo = new char[2];

string opcao;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(@$"
====================
BEM VINDO AO SISTEMA
====================

1 - Cadastro de produtos
2 - Listagem de produtos

0 - Sair 
");

opcao = Console.ReadLine();

while (opcao != "1" && opcao != "2" && opcao != "0")
{
    Console.WriteLine(@$"Opção inválida, escolha uma das opções abaixo
====================
BEM VINDO AO SISTEMA
====================

1 - Cadastro de produtos
2 - Listagem de produtos

0 - Sair ");
    opcao = Console.ReadLine();
}
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Magenta;
switch (opcao)
{
    case "1":
        for (int i = 0; i <= 1; i++)
        {
            
            Console.WriteLine(@$"
Informe o nome {i + 1}º do produto que deseja cadastrar: ");
            produtosNome[i] = Console.ReadLine();

            Console.WriteLine(@$"
Informe o preço do {i + 1}º produto que deseja cadastrar: ");
            produtosPreco[i] = float.Parse(Console.ReadLine());

            Console.WriteLine(@$"
Informe se {i + 1}º produto cadastrado esta em promoção ou não esta em promoção(s/n): ");
            produtosPromo[i] = char.Parse(Console.ReadLine());

            if (produtosPromo[i] == 's')
            {
                produtosPromocao[i] = true;
            }
            else if (produtosPromo[i] == 'n')
            {
                produtosPromocao[i] = false;

            }
            else
            {
                Console.WriteLine($"Opção inválida");

            }

        }

        Console.WriteLine(@$"
            2 - Listagem de produtos
            0 - Sair ");
        opcao = Console.ReadLine();

        if (opcao == "2")
        {
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine(@$"
Nome do {i + 1}º produto cadastrado: {produtosNome[i]}");

                Console.WriteLine(@$"
Preço do {i + 1}º produto cadastrado: {produtosPreco[i]}");

                Console.WriteLine(@$"
O {i + 1}º produto cadastrado esta em promoção: {produtosPromocao[i]}");
            }
        }
        else if (opcao == "0")
        {
            Console.WriteLine(@$"
        ______________________________________
        *Obrigado por utilizar nosso sistema!*
        ");

        }
        break;

    case "2":
        for (int i = 0; i <= 1; i++)
        {
            Console.WriteLine(@$"
Nome do {i + 1}º produto cadastrado: nenhum produto cadastrado");

            Console.WriteLine(@$"
Preço do {i + 1}º produto cadastrado: {produtosPreco[i]}");

            Console.WriteLine(@$"
O {i + 1}º produto cadastrado esta em promoção: {produtosPromocao[i]}");
        }
        break;
    case "0":
        Console.WriteLine(@$"
        ______________________________________
        *Obrigado por utilizar nosso sistema!*
        ");
        break;

    default:
        break;
}



