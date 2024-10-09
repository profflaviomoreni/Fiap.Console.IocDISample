public class TelegramMensageiro : IMensageiro
{
    public void EnviarMensagem(string msg)
    {
        Console.WriteLine($"Enviando Telegram: {msg}");
    }
}
