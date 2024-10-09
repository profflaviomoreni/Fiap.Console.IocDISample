public class EnviadorMensagem
{

    private IMensageiro _mensageiro;

    public EnviadorMensagem(IMensageiro mensageiro)
    {
        _mensageiro = mensageiro;
    }

    public void Enviar(string msg)
    {
        _mensageiro.EnviarMensagem(msg);
    }

}
