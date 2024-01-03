using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "996085486", modelo: "Modelo inexistente", imei: "1111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "993124300", modelo: "Modelo estranho", imei: "2222222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
