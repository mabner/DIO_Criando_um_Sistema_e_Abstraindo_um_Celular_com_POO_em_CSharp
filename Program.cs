using System.Globalization;
using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "123456", modelo: "N95", imei: "1234567891234", memoria: 128);
nokia.Ligar();
nokia.MostrarModelo("Nokia", nokia.Modelo, nokia.Memoria);
nokia.InstalarAplicativo("Fishing Planet");
nokia.InstalarAplicativo("Spotify");

Console.WriteLine("\n");

Smartphone iphone = new Iphone("45678", "6S", "123789852741", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Magic Hour");
iphone.ReceberLigacao();