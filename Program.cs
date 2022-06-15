using csharp_poo_exercises.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Cadastro e simulação de veículo.");

        Console.WriteLine("Qual a marca do seu veículo?");
        string marca = Console.ReadLine();

        Console.WriteLine("Qual o modelo do seu veículo?");
        string modelo = Console.ReadLine();

        Console.WriteLine("Qual a placa do seu veículo?");
        string placa = Console.ReadLine();

        Console.WriteLine("Qual a cor do seu veículo?");
        string cor = Console.ReadLine();

        Console.WriteLine("Qual a quilometragem do seu veículo?");
        var km = float.Parse(Console.ReadLine());

        Console.WriteLine("Qual o preço do seu veículo?");
        var preco = double.Parse(Console.ReadLine());

        Veiculo veiculo = new Veiculo(marca, modelo, placa, cor, km, preco);
        System.Console.WriteLine("\nVeículo cadastrado. Entrando no modo de simulação.");
        System.Console.WriteLine("--------------------------------------------------");
        string opcaoUsuario = "";
        while (opcaoUsuario != "X")
        {
            
            System.Console.WriteLine("Digite uma das opções disponíveis:");
            System.Console.WriteLine("1- Abastecer");
            System.Console.WriteLine("2- Ligar");
            System.Console.WriteLine("3- Desligar");
            System.Console.WriteLine("4- Acelerar");
            System.Console.WriteLine("5- Frear");
            System.Console.WriteLine("6- Pintar o carro");
            System.Console.WriteLine("7- Info");
            System.Console.WriteLine("X- Sair do programa");
            System.Console.WriteLine("");
            opcaoUsuario = Console.ReadLine();
            switch (opcaoUsuario)
            {
                case "1":
                    System.Console.WriteLine("Quantos litros você deseja abastecer?");
                    int litrosAbastecer = int.Parse(Console.ReadLine());
                    veiculo.Abastecer(litrosAbastecer);
                    break;
                case "2":
                    veiculo.Ligar();
                    break;
                case "3":
                    veiculo.Desligar();
                    break;
                case "4":
                    veiculo.Acelerar();
                    break;
                case "5":
                    veiculo.Frear();
                    break;
                case "6":
                    System.Console.WriteLine("Qual cor você deseja pintar o veículo?");
                    var corNova = Console.ReadLine();
                    veiculo.Pintar(corNova);
                    break;
                case "7":
                    System.Console.WriteLine(veiculo.ToString());
                    break;
                case "X":
                    System.Console.WriteLine("Saindo do programa.");
                    break;
                default:
                    System.Console.WriteLine("Opção inválida");
                    break;
            }
        System.Console.WriteLine("");
        System.Console.WriteLine("Digite qualquer teclar para continuar"+"\n---------------------------------------");
        Console.ReadKey();
        }
    }
}