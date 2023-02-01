using DesafioPOO.Models;

// Testando o programa.
// Feito

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "543210", modelo: "Tijolão", imei: "666666666", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Tinder");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "678910", modelo: "Incarregável", imei: "7777777777", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");