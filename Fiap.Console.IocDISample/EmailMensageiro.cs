
 public class EmailMensageiro : IMensageiro  
 {

    public void EnviarMensagem(string msg)
    {
        Console.WriteLine($"Enviando Email: {msg}");
    }
}
