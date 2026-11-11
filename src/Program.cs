using src.Convert;

public class Program {
    public static async Task Main(){
        String a = "fds!";
        var dow = new Dowloader();
        Console.Write("Digite a URL: ");
        String? b = Console.ReadLine();
        if (b == null)
        {
            Console.WriteLine("Erro URL não definida");
        } else {
            a = b;
            await dow.FazerDowload(a);
        }
    }
}
