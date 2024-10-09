
// Criando o enviador diretamente dentro do código principal


IMensageiro mensageiroWhats = new WhatsappMensageiro();
EnviadorMensagem enviador = new EnviadorMensagem(mensageiroWhats);
enviador.Enviar(" Whats ");



EnviadorMensagem env2 = new EnviadorMensagem(new EmailMensageiro());
env2.Enviar(" Email ");


/*
EnviadorMensagem enviador = new EnviadorMensagem();
enviador.EnviarSms("Olá, esta é uma mensagem SMS!");

enviador.EnviarWhatsapp("Olá, esta é uma mensagem WhatsApp!");

enviador.EnviarEmail("Olá, esta é uma mensagem Email!");
*/