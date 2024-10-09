
 public class WhatsappMensageiro : IMensageiro
 {

    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando WhatsApp: {mensagem}");
    }

}
