using DesafioPOO.Models;

Console.WriteLine("Smartfone Nokia: ");
Smartphone Nokai = new Nokia(numero: "1101", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
Nokai.Ligar();
Nokai.ReceberLigacao();
Nokai.InstalarAplicativo("Genshin");

Console.WriteLine("\n----------------------------\n"); 

Console.WriteLine("Smartfomne Iphone");
Smartphone Iphone = new Iphone(numero: "0213", modelo: "Modelo 2", imei: "2222222222", memoria: 128);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Pokemon Go");