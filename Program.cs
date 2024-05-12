using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345678",memoria: 32, modelo: "m12",imei:"3232321");
nokia.Ligar();
nokia.InstalarAplicativo("roblox");
Console.WriteLine("\n");



Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone(numero: "12345678",memoria: 32, modelo: "m12",imei:"3232321");
iphone.Ligar();
iphone.InstalarAplicativo("roblox");