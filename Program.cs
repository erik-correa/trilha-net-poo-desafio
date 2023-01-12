using DesafioPOO.Models;

Iphone iphone = new Iphone(454545, "iphone 8", 55458787, 4);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Nokia nokia = new Nokia(1233, "G20", 54447, 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Waze");