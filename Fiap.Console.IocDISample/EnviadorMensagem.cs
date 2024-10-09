public class EnviadorMensagem
{
    private SmsMensageiro _smsMensageiro;
    private WhatsappMensageiro _whatsappMensageiro;
    private EmailMensageiro _emailMensageiro;

    public EnviadorMensagem()
    {
        // Instanciando as dependências diretamente na classe
        _smsMensageiro = new SmsMensageiro();
        _whatsappMensageiro = new WhatsappMensageiro();
        _emailMensageiro = new EmailMensageiro();
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

}
