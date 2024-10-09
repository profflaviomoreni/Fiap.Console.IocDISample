public class SmsMensageiro : IMensageiro
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }

}
