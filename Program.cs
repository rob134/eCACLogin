using eCACLogin.Services;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Escolha o método de login:");
        Console.WriteLine("1 - Gov.br (Usuário e Senha)");
        Console.WriteLine("2 - Certificado Digital A1");
        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                await LoginViaGovBr();
                break;
            case "2":
                LoginViaCertificate();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    static async Task LoginViaGovBr()
    {
        Console.Write("Usuário (CPF ou email): ");
        var username = Console.ReadLine();

        Console.Write("Senha: ");
        var password = Console.ReadLine();

        var service = new GovBrLoginService();
        var result = await service.Login(username, password);

        Console.WriteLine(result.Message);
    }

    static void LoginViaCertificate()
    {
        var service = new CertificateLoginService();
        var result = service.Login();

        Console.WriteLine(result.Message);
    }
}
