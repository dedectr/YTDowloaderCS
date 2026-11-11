using src.Infra.Dowloader;

public class Program {
    public static async Task Main(){
        String a = "fds!";
        var dow = new Dowloaders();
        Console.Write("Digite a URL: ");
        String? b = Console.ReadLine();
        if (b == null)
        {
            Console.WriteLine("Erro URL não definida");
        } else {
            a = b;
            await dow.DowloaderAudio(a);
        }
    }
}
