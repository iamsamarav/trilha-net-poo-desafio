using DesafioPOO.Models;

Iphone celularUm = new Iphone("81983649752", "Iphone 8", "356080093924233", 256);
celularUm.InstalarAplicativo("DIO");
celularUm.Ligar();
celularUm.ReceberLigacao();

Nokia celularDois = new Nokia("81992569335", "Windows Phone", "356080095975431", 256);
celularDois.InstalarAplicativo("DIO");
celularDois.Ligar();
celularDois.ReceberLigacao();