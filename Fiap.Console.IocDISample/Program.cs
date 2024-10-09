
// Criando o enviador diretamente dentro do código principal

// Fabricio
IMensageiro mensageiroWhats = new WhatsappMensageiro();
EnviadorMensagem enviador = new EnviadorMensagem(mensageiroWhats);
enviador.Enviar(" Whats ");


// Elis 
EnviadorMensagem env2 = new EnviadorMensagem(new EmailMensageiro());
env2.Enviar(" Email ");


// Flavio
EnviadorMensagem env3 = new EnviadorMensagem(new SmsMensageiro());
env3.Enviar(" SMS ");



// Aguinaldo
EnviadorMensagem env4 = new EnviadorMensagem(new TelegramMensageiro());
env4.Enviar(" Telegram ");


