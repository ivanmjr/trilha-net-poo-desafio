using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("998754320", "A1", "MC1234", 8);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone ("988386805", "7 Plus", "IP0055", 16);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.Ligar();