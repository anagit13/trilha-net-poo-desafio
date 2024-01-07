using DesafioPOO.Models;

// TESTE DO SMARTPHONE IPHONE
Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "482956", modelo: "Modelo Y", imei: "777777777", memoria: "64");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Duolingo");

Console.WriteLine("\n");

// TESTE DO SMARTPHONE NOKIA
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "569178", modelo: "Modelo X", imei: "888888888", memoria: "32"); 
nokia.Ligar(); 
nokia.InstalarAplicativo("Canva");
