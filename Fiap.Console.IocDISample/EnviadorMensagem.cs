public class EnviadorMensagem
{
    private SmsMensageiro _smsMensageiro;
    private WhatsappMensageiro _whatsappMensageiro;
    private EmailMensageiro _emailMensageiro;
    private TelegramMensagerio _telegramMensagerio;

    public EnviadorMensagem()
    {
        // Instanciando as dependências diretamente na classe
        _smsMensageiro = new SmsMensageiro();
        _whatsappMensageiro = new WhatsappMensageiro();
        _emailMensageiro = new EmailMensageiro();
        _telegramMensagerio = new TelegramMensagerio();
    }

    public void EnviarSms(string mensagem)
    {
        _smsMensageiro.EnviarMensagem(mensagem);
    }

    public void EnviarWhatsapp(string mensagem)
    {
        _whatsappMensageiro.EnviarMensagem(mensagem);
    }

    public void EnviarEmail(string mensagem)
    {
        _emailMensageiro.EnviarEmail(mensagem);
    }


    public void SendTelegram(string msg)
    {
        _telegramMensagerio.SendMessage(msg);
    }

}
