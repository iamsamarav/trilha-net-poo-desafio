using DesafioPOO.Models;

Smartphone celularUm = new Iphone("81983649752", "Iphone 8", "356080093924233", 256);
Console.WriteLine("Smartphone Iphone:");
celularUm.InstalarAplicativo("DIO");
celularUm.Ligar();

Smartphone celularDois = new Nokia("81992569335", "Windows Phone", "356080095975431", 256);
Console.WriteLine("Smartphone Nokia:");
celularDois.InstalarAplicativo("DIO");
celularDois.ReceberLigacao();