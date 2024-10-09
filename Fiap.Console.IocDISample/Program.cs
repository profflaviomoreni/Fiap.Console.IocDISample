
// Criando o enviador diretamente dentro do código principal
EnviadorMensagem enviador = new EnviadorMensagem();
enviador.EnviarSms("Olá, esta é uma mensagem SMS!");

enviador.EnviarWhatsapp("Olá, esta é uma mensagem WhatsApp!");

enviador.EnviarEmail("Olá, esta é uma mensagem Email!");